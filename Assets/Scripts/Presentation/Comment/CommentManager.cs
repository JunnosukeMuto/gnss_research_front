using Assets.Scripts.Application.Comment;
using Assets.Scripts.Domain.Comment;
using Assets.Scripts.Domain.GNSS;
using Assets.Scripts.Domain.VR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UniRx;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Presentation.Comment
{
    internal class CommentManager : MonoBehaviour, ICommentManager
    {
        [SerializeField] private CommentViewModel commentPrefab;

        [Inject] private readonly ICommentRepository _commentRepository;
        [Inject] private readonly IGNSSAdapter _gnssAdapter;
        [Inject] private readonly IVRAdapter _vrAdapter;

        private ICommentUseCase.IFactory _factory;
        private DiContainer _container;

        // Unity空間に表示されるコメントインスタンス（サーバにもあるとは限らない）
        private readonly List<ICommentViewModel> _commentInstances = new();

        public CommentManager()
        {
            // 現在地GridIdが変わったら全部作り直し
            _gnssAdapter.Location
                .Select(l => l.CalcGridId())
                .DistinctUntilChanged()
                .Subscribe(id => RefreshComments(id))
                .AddTo(this);

            // 最初のグリッドのコメント表示
            RefreshComments(_gnssAdapter.Location.Value.CalcGridId());
        }

        // Zenjectが開始時に呼ぶ
        [Inject]
        public void Construct(ICommentUseCase.IFactory factory, DiContainer container)
        {
            _factory = factory;
            _container = container;
        }

        public void CreateComment(CommentEntity comment)
        {
            ICommentUseCase useCase = _factory.Create(comment);
            CommentViewModel commentInstance = Instantiate(commentPrefab);
            _container.Inject(commentInstance, new object[] { useCase });
            _commentInstances.Add(commentInstance);
        }

        public async Task DeleteCommentAsync(int id)
        {
            try
            {
                ICommentViewModel found = _commentInstances.Find(vm => vm.Id.Value == id);
                _commentInstances.Remove(found);

                // TODO: idで判定してサーバに格納されているデータも消す
            }
            catch
            {
            }
        }

        private async Task RefreshComments(string currentGridId)
        {
            // TODO: 周囲3x3グリッドのコメントを取得しなおして、位置も計算しなおす

            // とりあえず現在グリッドだけ
            CommentEntity[] comments = await _commentRepository.FindByGridIdAsync(currentGridId);

            GNSSLocation userLocation = _gnssAdapter.Location.Value;
            var userPos = _vrAdapter.Position.Value;

            const double e = 0.081819191042815791;  // 地球の離心率 (GRS80に従う)
            const double e_square = e * e;
            const double a = 6378137.0;             // 地球の長半径 (GRS80に従う)

            foreach (var cmt in comments)
            {
                // ヒュベニの公式で緯度経度の差から距離の差を求める
                double d_lat = cmt.Location.LatRad - userLocation.LatRad;  // 緯度差
                double d_lon = cmt.Location.LonRad - userLocation.LonRad;  // 経度差
                double avg_lat = (cmt.Location.LatRad + userLocation.LatRad) / 2.0; // 緯度平均
                double sin_avg_lat = Math.Sin(avg_lat);
                double w = Math.Sqrt(1.0 - e_square * sin_avg_lat * sin_avg_lat);   // 曲率半径の分母
                double m = a * (1.0 - e_square) / w * w * w;    // 子午線曲率半径
                double n = a / w;   // 卯酉線（ぼうゆうせん）曲率半径

                double dx = n * d_lon * Math.Cos(avg_lat);
                double dy = m * d_lat;

                // TODO: Unityが適当に決めたXYではなく、地球の緯度・経度に対応したXY座標でInstantiateする
                // TODO: CommentではなくObjectBaseに置き換える（Objectの種類をenumで定義してやってswitchでプレハブ選択？）
                // TODO: 計算ロジックをObjectBaseに移す
                // TODO: heightも計算する
                ICommentUseCase useCase = _factory.Create(cmt);
                // Unity空間での加速度センサをもとに測定された現在座標は、動き回るうちに正確な現在座標からズレが生じると考える。
                // 開始時に(0,0)が対応する緯度経度を測定しても、グリッド移動時にはその対応は信用できないので、
                // 直近の測定をもとに相対座標で全部描画しなおす仕組み。
                CommentViewModel commentInstance = Instantiate(commentPrefab, new UnityEngine.Vector3(userPos.X + (float)dx, userPos.Y + (float)dy, 1.0f), new UnityEngine.Quaternion());
                _container.Inject(commentInstance, new object[] { useCase });
                _commentInstances.Add(commentInstance);
            }
        }
    }
}

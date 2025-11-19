using Assets.Scripts.Domain.Comment;
using Assets.Scripts.Domain.GNSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UniRx;
using Zenject;

namespace Assets.Scripts.Application.Comment
{
    internal interface ICommentUseCase
    {
        IReadOnlyReactiveProperty<int> Id { get; }
        IReadOnlyReactiveProperty<string> GridID { get; }
        IReadOnlyReactiveProperty<GNSSLocation> Location { get; }
        IReadOnlyReactiveProperty<Vector4> Quat { get; }
        IReadOnlyReactiveProperty<string> Text { get; }

        void UpdateComment(string gridId, GNSSLocation location, Vector4 quat, string text);

        // CreateCommentAsync()でコメントを空間に表示、SubmitCommentAsync()で作った/更新したコメントをサーバに送信
        Task<bool> SubmitCommentAsync();

        // Zenjectの自動生成Factory。TransientなUseCaseを実現する。
        interface IFactory
        {
            ICommentUseCase Create(CommentEntity comment);
        }
    }
}

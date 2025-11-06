using Assets.Scripts.Domain.Comment;
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
        IReadOnlyReactiveProperty<Vector3> XYZ { get; }
        IReadOnlyReactiveProperty<Vector4> Quat { get; }
        IReadOnlyReactiveProperty<string> GridID { get; }
        IReadOnlyReactiveProperty<string> Text { get; }

        void UpdateComment(string gridId, Vector3 xyz, Vector4 quat, string text);

        // CreateCommentAsync()でコメントを空間に表示、SubmitCommentAsync()で作った/更新したコメントをサーバに送信
        Task<bool> SubmitCommentAsync();
    }
}

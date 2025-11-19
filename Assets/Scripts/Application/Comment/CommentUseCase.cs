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
    // ドメインモデルを保持し、値の変更を下層に通知する。また、状態更新のためのメソッドを持つ。
    internal class CommentUseCase : ICommentUseCase
    {
        private CommentEntity _comment;

        private ReactiveProperty<int> _id = new();
        private ReactiveProperty<string> _gridId = new();
        private ReactiveProperty<GNSSLocation> _location = new();
        private ReactiveProperty<Vector4> _quat = new();
        private ReactiveProperty<string> _text = new();

        public IReadOnlyReactiveProperty<int> Id => _id;
        public IReadOnlyReactiveProperty<string> GridID => _gridId;
        public IReadOnlyReactiveProperty<GNSSLocation> Location => _location;
        public IReadOnlyReactiveProperty<Vector4> Quat => _quat;
        public IReadOnlyReactiveProperty<string> Text => _text;

        public CommentUseCase(CommentEntity comment)
        {
            _comment = comment;
            _id.Value = comment.Id;
            _gridId.Value = comment.GridId;
            _location.Value = comment.Location;
            _quat.Value = comment.Quat;
            _text.Value = comment.Text;
        }

        public Task<bool> SubmitCommentAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(string gridId, GNSSLocation location, Vector4 quat, string text)
        {
            throw new NotImplementedException();
        }

        // Zenjectの自動生成Factory。TransientなUseCaseを実現する。
        public class Factory : PlaceholderFactory<CommentEntity, CommentUseCase>, ICommentUseCase.IFactory
        {
            ICommentUseCase ICommentUseCase.IFactory.Create(CommentEntity comment)
            {
                return Create(comment);
            }
        }
    }
}

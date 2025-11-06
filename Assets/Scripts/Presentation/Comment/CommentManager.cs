using Assets.Scripts.Application.Comment;
using Assets.Scripts.Domain.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Presentation.Comment
{
    internal class CommentManager : MonoBehaviour, ICommentManager
    {
        [SerializeField] private CommentViewModel commentPrefab;

        private CommentUseCase.Factory _factory;
        private DiContainer _container;
        private readonly List<CommentViewModel> _commentInstances = new();

        // Zenjectが開始時に呼ぶ
        [Inject]
        public void Construct(CommentUseCase.Factory factory, DiContainer container)
        {
            _factory = factory;
            _container = container;
        }

        public void CreateComment(CommentEntity comment)
        {
            var useCase = _factory.Create(comment);
            var commentInstance = Instantiate(commentPrefab);
            _container.Inject(commentInstance, new object[] { useCase });
            _commentInstances.Add(commentInstance);
        }

        public async Task<bool> DeleteCommentAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

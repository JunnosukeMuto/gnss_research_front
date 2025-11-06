using Assets.Scripts.Application.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UniRx;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Presentation.Comment
{
    internal class CommentViewModel : MonoBehaviour, ICommentViewModel
    {
        [Inject] private readonly ICommentUseCase _useCase;

        private CompositeDisposable _disposables = new();

        public TextMeshProUGUI textMesh;

        private void Start()
        {
            _useCase.Text
                .Subscribe(text => textMesh.text = text)
                .AddTo(_disposables);
        }

        private void OnDestroy()
        {
            _disposables.Dispose();
        }
    }
}

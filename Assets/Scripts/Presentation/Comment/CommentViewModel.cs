using Assets.Scripts.Application.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Presentation.Comment
{
    internal class CommentViewModel : MonoBehaviour, ICommentViewModel
    {
        [Inject] private readonly ICommentUseCase useCase;

    }
}

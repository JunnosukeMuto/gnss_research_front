using Assets.Scripts.Application.Comment;
using Assets.Scripts.Domain.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace Assets.Scripts.Presentation.Installer
{
    internal class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindFactory<CommentEntity, CommentUseCase, CommentUseCase.Factory>()
                .AsTransient();
        }
    }
}

using Assets.Scripts.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;

namespace Assets.Scripts.Application.User
{
    internal interface IUserUseCase
    {
        IReadOnlyReactiveProperty<int> Id { get; }
        IReadOnlyReactiveProperty<string> Name { get; }
        Task<UserEntity> Login(string email, string password);
        Task Logout();
        Task<UserEntity> Register(string username, string email, string password);
    }
}

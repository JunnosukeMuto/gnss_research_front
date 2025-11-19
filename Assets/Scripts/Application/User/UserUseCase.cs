using Assets.Scripts.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;
using Zenject;

namespace Assets.Scripts.Application.User
{
    internal class UserUseCase : IUserUseCase
    {
        [Inject] private readonly IUserRepository _userRepository;

        private UserEntity _currentUser;

        private ReactiveProperty<int> _id = new();
        private ReactiveProperty<string> _name = new();

        public IReadOnlyReactiveProperty<int> Id => _id;
        public IReadOnlyReactiveProperty<string> Name => _name;

        public async Task<UserEntity> Login(string email, string password)
        {
            try
            {
                UserEntity found = await _userRepository.FindByEmail(email, password);
                _currentUser = found;
                _id.Value = found.Id;
                _name.Value = found.Name;
                return found;
            }
            catch
            {
                throw new ArgumentException("メールアドレスかパスワードのどちらかが間違っています");
            }
        }

        public async Task Logout()
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> Register(string username, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}

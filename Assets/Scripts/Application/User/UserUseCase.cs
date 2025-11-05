using Assets.Scripts.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Application.User
{
    internal class UserUseCase : IUserUseCase
    {
        public UserEntity CurenntUser { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }

        public bool Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }
    }
}

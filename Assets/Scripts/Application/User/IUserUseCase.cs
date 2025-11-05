using Assets.Scripts.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Application.User
{
    internal interface IUserUseCase
    {
        UserEntity? CurenntUser { get; }
        bool Login(string email, string password);
        bool Register(string username, string email, string password);
        bool Logout();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Domain.User
{
    internal interface IUserRepository
    {
        Task<UserEntity?> FindById(int id);
        Task<UserEntity?> FindByEmail(string email);
        Task<UserEntity?> RegisterUser(string username, string email, string password);
    }
}

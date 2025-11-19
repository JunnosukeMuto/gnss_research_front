using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Domain.User
{
    internal interface IUserRepository
    {
        Task<UserEntity> Create(string username, string email, string password);   // サーバでIDが付与されて返ってくる
        Task Delete(int id, string password);
        Task<UserEntity> FindById(int id, string password);
        Task<UserEntity> FindByEmail(string email, string password);
    }
}

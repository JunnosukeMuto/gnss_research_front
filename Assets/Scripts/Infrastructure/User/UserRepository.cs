using Assets.Scripts.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Infrastructure.User
{
    internal class UserRepository : IUserRepository
    {
        public Task<UserEntity> Create(string username, string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> FindByEmail(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> FindById(int id, string password)
        {
            throw new NotImplementedException();
        }

    }
}

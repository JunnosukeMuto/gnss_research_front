using Assets.Scripts.Domain.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Infrastructure.Comment
{
    internal class CommentRepository : ICommentRepository
    {
        public async Task<CommentEntity> FindByGridIdAsync(int gridId)
        {
            throw new NotImplementedException();
        }

        public async Task<CommentEntity> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

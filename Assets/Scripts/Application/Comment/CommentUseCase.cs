using Assets.Scripts.Domain.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Application.Comment
{
    internal class CommentUseCase : ICommentUseCase
    {
        public async Task<bool> CreateCommentAsync(CommentEntity comment)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCommentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CommentEntity[]> GetCommentsAroundAsync(int GridId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCommentAsync(CommentEntity comment)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Domain.Comment
{
    internal interface ICommentRepository
    {
        Task<CommentEntity?> FindByIdAsync(int id);
        Task<CommentEntity?> FindByGridIdAsync(int gridId);
    }
}

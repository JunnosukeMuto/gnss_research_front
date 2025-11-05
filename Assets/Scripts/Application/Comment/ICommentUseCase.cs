using Assets.Scripts.Domain.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Application.Comment
{
    internal interface ICommentUseCase
    {
        // TODO: いまいちコメントのユースケース（処理の流れ）が見えてこないので一旦View側に着手する
        // CommentEntity.Idはサーバ側で決めるのでここでは0にする
        Task<bool> CreateCommentAsync(CommentEntity comment);

        // CommentEntity.Idに更新したいコメントのIDを入れる
        Task<bool> UpdateCommentAsync(CommentEntity comment);
        Task<bool> DeleteCommentAsync(int id);
        Task<CommentEntity[]> GetCommentsAroundAsync(int GridId);
    }
}

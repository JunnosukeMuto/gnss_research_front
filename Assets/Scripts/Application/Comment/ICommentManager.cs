using Assets.Scripts.Domain.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Application.Comment
{
    internal interface ICommentManager
    {
        // CommentEntity.Idはサーバに登録したものの空間とまだ送信していないローカル上のものの空間を分ける
        // でないとサーバに登録していないコメントをDeleteできない
        void CreateComment(CommentEntity comment);

        // idがサーバ空間だったらDB処理を実行するのでasync
        Task<bool> DeleteCommentAsync(int id);
    }
}

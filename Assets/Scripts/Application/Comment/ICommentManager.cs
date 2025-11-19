using Assets.Scripts.Domain.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Application.Comment
{
    // 責務：コメントの動的生成、保持
    internal interface ICommentManager
    {
        // CommentEntity.Idはサーバに登録したidとまだ送信していないローカル上のidのアドレス空間を分ける
        // でないとサーバに登録していないコメントをDeleteできない
        void CreateComment(CommentEntity comment);

        // idがサーバ空間だったらDB処理を実行するのでasync
        Task DeleteCommentAsync(int id);
    }
}

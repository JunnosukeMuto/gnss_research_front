using Assets.Scripts.Domain.ObjectBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Domain.Comment
{
    internal class CommentEntity : ObjectBaseEntity
    {
        public string Text { get; init; }
    }
}

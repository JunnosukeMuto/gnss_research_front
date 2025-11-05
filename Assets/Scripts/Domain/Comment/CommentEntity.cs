using Assets.Scripts.Domain.ObjectBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Domain.Comment
{
    internal class CommentEntity : ObjectBaseEntity
    {
        private static int maxLength = 50;

        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                if (value.Length > maxLength)
                {
                    throw new ArgumentException("max length of comment text is: " + maxLength);
                }
                _text = value;
            }
        }

        public CommentEntity(Vector3 xyz, Vector4 quat, int authorId, string gridId, string text, int id = 0)
            : base(xyz, quat, authorId, gridId, id)
        {
            Text = text;
        }
    }
}

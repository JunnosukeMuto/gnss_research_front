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

        public CommentEntity(int id, int authorId, string gridId, Vector3 xyz, Vector4 quat,  string text)
            : base(id, authorId, gridId, xyz, quat)
        {
            Text = text;
        }
    }
}

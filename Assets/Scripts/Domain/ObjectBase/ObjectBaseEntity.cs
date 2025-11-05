using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Domain.ObjectBase
{
    internal class ObjectBaseEntity
    {
        public int Id { get; init; }
        public int AuthorId { get; init; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float QuatX { get; set; }
        public float QuatY { get; set; }
        public float QuatZ { get; set; }
        public float QuatW { get; set; }
        public string GridId { get; set; }

        ObjectBaseEntity(int id, int authorId, Vector3 xyz, Vector4 quat, string gridId)
        {
            Id = id;
            AuthorId = authorId;
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            QuatX = quat.X;
            QuatY = quat.Y;
            QuatZ = quat.Z;
            QuatW = quat.W;
            GridId = gridId;
        }
    }
}

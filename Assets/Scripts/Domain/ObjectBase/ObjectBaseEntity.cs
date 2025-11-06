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
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string GridId { get; set; }
        public Vector3 XYZ { get; set; }
        public Vector4 Quat { get; set; }
        public float X => XYZ.X;
        public float Y => XYZ.Y;
        public float Z => XYZ.Z;
        public float QuatX => Quat.X;
        public float QuatY => Quat.Y;
        public float QuatZ => Quat.Z;
        public float QuatW => Quat.W;

        public ObjectBaseEntity(int id, int authorId, string gridId, Vector3 xyz, Vector4 quat)
        {
            Id = id;
            AuthorId = authorId;
            GridId = gridId;
            XYZ = xyz;
            Quat = quat;
        }
    }
}

using Assets.Scripts.Domain.GNSS;
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
        public string GridId => Location.CalcGridId();
        public GNSSLocation Location { get; set; }
        public Vector4 Quat { get; set; }

        public ObjectBaseEntity(int id, int authorId, GNSSLocation location, Vector4 quat)
        {
            Id = id;
            AuthorId = authorId;
            Location = location;
            Quat = quat;
        }
    }
}

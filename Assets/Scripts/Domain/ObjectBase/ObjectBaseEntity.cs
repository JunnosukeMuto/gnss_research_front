using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Domain.ObjectBase
{
    internal class ObjectBaseEntity
    {
        public int Id { get; init; }
        public int AuthorId { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
        public int Z { get; init; }
        public int QuatX { get; init; }
        public int QuatY { get; init; }
        public int QuatZ { get; init; }
        public int QuatW { get; init; }
        public string GridId { get; init; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UniRx;

namespace Assets.Scripts.Domain.GNSS
{
    internal interface IGNSSAdapter
    {
        // x:latitude, y:height, z:longitude
        IReadOnlyReactiveProperty<GNSSLocation> Location { get; }
        Task SocketConnect();
        Task SocketClose();
    }
}

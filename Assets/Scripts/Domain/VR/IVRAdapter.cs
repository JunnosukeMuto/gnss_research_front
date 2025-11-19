using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;

namespace Assets.Scripts.Domain.VR
{
    internal interface IVRAdapter
    {
        IReadOnlyReactiveProperty<System.Numerics.Vector3> Position { get; }

    }
}

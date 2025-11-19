using Assets.Scripts.Domain.GNSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRx;

namespace Assets.Scripts.Infrastructure.GNSS
{
    internal class GNSSAdapter : IGNSSAdapter
    {
        // 一度に全部変わるのでこれでOK
        private ReactiveProperty<GNSSLocation> _location = new();

        public IReadOnlyReactiveProperty<GNSSLocation> Location => _location;

        public Task SocketClose()
        {
            throw new NotImplementedException();
        }

        public Task SocketConnect()
        {
            throw new NotImplementedException();
        }
    }
}

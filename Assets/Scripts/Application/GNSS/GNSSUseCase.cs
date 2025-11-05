using Assets.Scripts.Domain.GNSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Application.GNSS
{
    internal class GNSSUseCase : IGNSSUseCase
    {
        public async Task<GNSSPlace> GetPlaceAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdatePlaceAsync(GNSSPlace place)
        {
            throw new NotImplementedException();
        }
    }
}

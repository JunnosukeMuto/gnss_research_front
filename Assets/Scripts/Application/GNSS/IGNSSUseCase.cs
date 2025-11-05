using Assets.Scripts.Domain.GNSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Application.GNSS
{
    internal interface IGNSSUseCase
    {
        Task<bool> UpdatePlaceAsync(GNSSPlace place);
        Task<GNSSPlace> GetPlaceAsync();
    }
}

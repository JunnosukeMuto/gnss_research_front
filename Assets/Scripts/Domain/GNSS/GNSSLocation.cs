using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;

namespace Assets.Scripts.Domain.GNSS
{
    // Value Object
    internal class GNSSLocation
    {
        private double _lat;
        public double Lat
        {
            get => _lat;
            set
            {
                if (value > 90 || value < -90)
                {
                    throw new ArgumentException("緯度は90度までです");
                }
                _lat = value;
            }
        }
        public double LatRad => Lat * Math.PI / 180;

        private double _lon;
        public double Lon
        {
            get => _lon;
            set
            {
                if (value > 180 || value < -180)
                {
                    throw new ArgumentException("経度は180度までです");
                }
                _lon = value;
            }
        }
        public double LonRad => Lon * Math.PI / 180;

        public double Height { get; set; }

        public GNSSLocation(double lat, double lon, double height)
        {
            Lat = lat;
            Lon = lon;
            Height = height;
        }

        public string CalcGridId()
        {
            // TODO: Geohashを実装
            throw new NotImplementedException();
        }
    }
}

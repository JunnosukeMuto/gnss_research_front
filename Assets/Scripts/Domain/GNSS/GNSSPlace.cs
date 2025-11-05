using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Domain.GNSS
{
    internal class GNSSPlace
    {
        private float _lat;
        public float Latitude
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
        private float _long;
        public float Longitude
        {
            get => _long;
            set
            {
                if (value > 180 || value < -180)
                {
                    throw new ArgumentException("経度は180度までです");
                }
                _long = value;
            }
        }
        public float Height { get; set; }
    }
}

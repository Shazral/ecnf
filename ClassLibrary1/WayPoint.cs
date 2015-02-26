using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerLib
{
    public class WayPoint
    {
        public string Name { get; set; } 
        public double Longitude { get; set; } 
        public double Latitude { get; set; } 

        public WayPoint(string _name, double _latitude, double _longitude) 
        { 
            Name = _name; 
            Latitude = _latitude; 
            Longitude = _longitude;
        }

        public double Distance(WayPoint target){
            double d = 6371 * Math.Acos(Math.Sin(this.Latitude * Math.PI / 180) * Math.Sin(target.Latitude * Math.PI / 180) + Math.Cos(this.Latitude * Math.PI / 180) * Math.Cos(target.Latitude * Math.PI / 180) * Math.Cos((this.Longitude  - target.Longitude) * Math.PI / 180));
            return d;
        }

        public override string ToString()
        {
            if (Name == null)
            {
                return "WayPoint: " + Latitude.ToString("0.00") +"/" + Longitude.ToString("0.00");
            }
            else
            {
                return "WayPoint: " + Name + " " + Latitude.ToString("0.00") + "/" + Longitude.ToString("0.00");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerLib
{
    class wayPoint
    {
        public string Name { get; set; } 
        public double Longitude { get; set; } 
        public double Latitude { get; set; } 

        public wayPoint(string _name, double _latitude, double _longitude) 
        { 
            Name = _name; 
            Latitude = _latitude; 
            Longitude = _longitude; 
        }
    }
}

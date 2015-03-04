using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerLib
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public WayPoint Location { get; set; } 

        public City(string n, string c, int p, double latitude, double longitude){
            Name = n;
            Country = c;
            Population = p;
            Location = new WayPoint(n, latitude, longitude);
    }

    }
}

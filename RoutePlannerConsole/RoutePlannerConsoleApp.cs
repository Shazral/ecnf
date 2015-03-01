using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Fhnw.Ecnf.RoutePlanner.RoutePlannerLib;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerConsole
{
    class RoutePlannerConsoleApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RoutePlanner (Version {0})", Assembly.GetExecutingAssembly().GetName().Version);
            var wayPoint = new WayPoint("Windisch", 47.479319847061966, 8.212966918945312); 
         //   Console.WriteLine("{0}: {1}/{2}", wayPoint.Name, wayPoint.Latitude, wayPoint.Longitude);
            Console.WriteLine(wayPoint.ToString());
            var bern = new WayPoint("Bern", 46.985419, 7.320197);
            var tripolis = new WayPoint("Tripolis", 32.808714, 13.106475);
            double dist = bern.Distance(tripolis);
            Console.WriteLine(dist);
            string st = "ab     c";
            Console.WriteLine(st[0].Equals("a"));
            Console.WriteLine(st[0]);
            Cities cListe = new Cities();
            int i = cListe.ReadCities("citiesTestDataLab2.txt");
            Console.WriteLine(i);
            int count = cListe[0];
            Console.WriteLine("IndexerTest: " + count);
            Console.ReadKey();
        }


    }
}

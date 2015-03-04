using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhnw.Ecnf.RoutePlanner.RoutePlannerLib
{
    public class Cities
    {
        private List<City> ListOfCities;

        private int counter;

        public Cities()
        {
            ListOfCities = new List<City>();
        }

        public int Count
        {
            get
            {
                return ListOfCities.Count;
            }
        }

        public City this[int position]   // AUfgabe 2.c) <- Implementierung unklar
        {
            get 
            {
                if (ListOfCities.Count < 0 || position >= ListOfCities.Count) return null;
                else
                {   
                    return ListOfCities[position];
                }
            }
            set 
            {
                ListOfCities[position] = value;
            }
        }

        public List<City> FindNeighbours(WayPoint location, double distance)
        {
            List<City> neighbourCities = new List<City>();
            int i = 0;
            int size = ListOfCities.Count;
            foreach(City cit in ListOfCities) // iteriere durch ganze ListOfCities
            { 
                //berechnen der Distanz mit methode aus Waypoint
                WayPoint wp = cit.Location;
                double dist = wp.Distance(location);
                if(dist <= distance){ //Wenn berechnete Diszanz <= distance hinzufügen zu neighbourCities
                    neighbourCities.Add(cit);
                }
                i++;
            }
            return neighbourCities;
        }

        public int ReadCities(string filename)
        {
            counter = 0;
            string tab = "\t";
            string name = null;
            string country = null;
            int stringstart = 0;
            int population = 0;
            double latitude = 0;
            double longitude = 0;
            TextReader reader = new StreamReader(filename);
            string s = reader.ReadLine();
            while (s != null)
            {
                int i=0;
                int positionNumber = 0;
                while (i < s.Length)
                {
                    string letter1 = s[i].ToString();
                    if (letter1.Equals(tab) || i==s.Length-1)
                    {

                        string add = null;
                        while (stringstart < i)
                        {
                            add += s[stringstart];
                            stringstart++;
                        }
                        if (i == s.Length - 1) add += s[stringstart];
                        switch (positionNumber)
                        {
                            case 0: 
                                name = add; 
                                break;
                            case 1:
                                country = add;
                                break;
                            case 2:
                                population = Convert.ToInt32(add);
                                break;
                            case 3:
                                latitude = Convert.ToDouble(add);
                                break;
                            case 4:
                                longitude = Convert.ToDouble(add);
                                break;
                        }
                       
                        positionNumber++;
                        stringstart = i+1;
                    }           
                    i++;
                }
                ListOfCities.Add(new City(name, country, population, latitude, longitude));
                counter++;
                i = 0;
                stringstart = 0;
                s =reader.ReadLine();
            }

            return counter;
        }

    }
}

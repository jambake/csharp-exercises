using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cities;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            City saintLouis = new City("St. Louis", 318416, "MO");
            City denver = new City("Denver", 649495, "CO");
            City losAngeles = new City("Los Angeles", 3884000, "CA");
            City newYork = new City("New York", 8406000, "NY");
            City chicago = new City("Chicago", 2719000, "IL");
            City newOrleans = new City("New Orleans", 378715, "LA");

            List<City> cities = new List<City>();

            cities.Add(saintLouis);
            cities.Add(denver);
            cities.Add(losAngeles);
            cities.Add(newYork);
            cities.Add(chicago);
            cities.Add(newOrleans);

            Console.WriteLine(City.GetSortByName());

            Console.ReadLine();
        }
    }
}

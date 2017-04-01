using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities
{
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string State { get; set; }

        public City(string name, int population, string state)
        {
            Name = name;
            Population = population;
            State = state;
        }

        public override string ToString()
        {
            return string.Format("{0, -20}{1, -24}{2, -10}", Name, State, Population);
        }

        static private List<City> cities = new List<City>();

        public static IList<City> GetSortByName()
        {
            cities.Sort(new NameComparer());
            return cities;
        }

        public static IList<City> GetSortByPopulation()
        {
            cities.Sort(new PopulationComparer());
            return cities;
        }

        public static IList<City> GetSortByState()
        {
            cities.Sort(new StateComparer());
            return cities;
        }
    }
}

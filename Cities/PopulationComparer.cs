using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return x.Population - y.Population;
        }
    }
}

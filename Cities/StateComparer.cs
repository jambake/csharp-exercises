using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities
{
    public class StateComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return string.Compare(x.State, y.State);
            //((new CaseInsensitiveComparer()).Compare(x.Name, y.Name));
        }
    }
}

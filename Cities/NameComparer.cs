using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities
{
    public class NameComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return ((new CaseInsensitiveComparer()).Compare(x.Name, y.Name));
        }
    }
}

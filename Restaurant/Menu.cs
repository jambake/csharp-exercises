using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        // DateTime for last update of menu prop with backing field
        public Dictionary<string, List<string>> MenuItems { get; set; }
        
    }
}

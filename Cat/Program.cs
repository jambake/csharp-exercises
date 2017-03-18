using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HouseCat hobbes = new HouseCat("Hobbes", 12);

            hobbes.Eat();
        }
    }
}

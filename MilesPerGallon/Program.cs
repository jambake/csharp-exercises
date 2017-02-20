using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            double miles;
            double gallons;
            double milesPerGallon;

            do {
                Console.WriteLine("How many miles have you driven?");
                input = Console.ReadLine();
                miles = double.Parse(input);
            } while(miles < 1);

            do
            {
                Console.WriteLine("How much gas in gallons have you used?");
                input = Console.ReadLine();
                gallons = double.Parse(input);
            } while (gallons < 1);

            milesPerGallon = Math.Round((miles / gallons), 2);

            Console.WriteLine("You're Miles Per Gallon equals: " + milesPerGallon);
            Console.ReadLine();
        }
    }
}

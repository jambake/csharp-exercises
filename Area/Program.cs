using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double area;
            double radius;

            do
            {
                Console.Write("Please enter a positive radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
                // ...or...
                // string input = Console.ReadLine();
                // double radius = double.Parse(input);
            } while (radius < 0);
            
            area = 3.14 * radius * radius;
            Console.WriteLine("The area of a cirle with a radius of " + radius + " is " + area);

            Console.ReadLine();
        }
    }
}

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
                Console.WriteLine("Please enter a positive radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
            } while (radius < 0);
            
            area = 3.14 * radius * radius;
            Console.WriteLine("The Area = " + area);

            Console.ReadLine();
        }
    }
}

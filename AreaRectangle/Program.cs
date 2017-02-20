using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaRectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            int area;
            int width;
            int height;

            Console.WriteLine("Please enter a width: ");
            input = Console.ReadLine();
            width = int.Parse(input);

            Console.WriteLine("Please enter a Height: ");
            input = Console.ReadLine();
            height = int.Parse(input);

            area = width * height;

            Console.Write("The area of a rectangle with a width of " + width + " and a height of " + height + " equals " + area + ".");
            Console.ReadLine();
        }
    }
}

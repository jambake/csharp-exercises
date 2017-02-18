using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetMessage("fr");
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }

        private static string GetMessage(string lang)
        {
            if (lang.Equals("fr"))
            {
                return "Bonjour!";
            } else
            {
                return "Hello";
            }
        }
    }
}

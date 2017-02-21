using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] fibArray = new int[6] { 1, 1, 2, 3, 5, 8 };
            for (int i = 0; i < fibArray.Length; i++)
            {
                Console.Write("{0}\t", fibArray[i]);
            }
            Console.ReadLine();
        }
    }
}

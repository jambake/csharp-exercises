using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListEvenSum
{
    public class Program
    {
        public static int evenSum(List<int> numList)
        {
            int sum = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] % 2 == 0)
                {
                    sum += numList[i];
                    Console.Write(" + {0}", numList[i]);
                }
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(1, 100);
                nums.Add(randomNumber);
            }

            nums.ForEach(i => Console.Write(" {0} |", i));
            Console.WriteLine();
            Console.WriteLine("Evens:");
            Console.WriteLine(" = " + evenSum(nums).ToString());
            Console.ReadLine();
        }
    }
}

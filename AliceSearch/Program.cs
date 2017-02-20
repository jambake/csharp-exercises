using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            bool found = true;
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " + 
            "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
            "thought Alice 'without pictures or conversation?'";
            string aliceLower = alice.ToLower();

            Console.WriteLine("What word would you like to search for?");
            input = Console.ReadLine();
            
            if (alice.Contains(input) || aliceLower.Contains(input))
            {
                Console.WriteLine(found);
            } else
            {
                found = false;
                Console.WriteLine(found);
            }
            Console.ReadLine();
        }
    }
}

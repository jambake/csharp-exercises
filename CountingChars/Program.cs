using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CountingChars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            
            //Console.WriteLine("Please type in a message:");
            //string input = Console.ReadLine();
            

            string input = File.ReadAllText(@"C:\Users\User\Dropbox\lc101\test.txt");
            //input = input.ToLower();
            string alphabet = " ,.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string alphabet = "abcdefghijklmnopqrstuvwxyz";

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (alphabet.Contains(c)) {
                    if (letterCount.Keys.Contains(c))
                    {
                        letterCount[c] = letterCount[c] + 1;
                    } else
                    {
                        letterCount[c] = 1;
                    }
                }
            }
            List<char> list = letterCount.Keys.ToList();
            list.Sort();

            foreach (char key in list)
            {
                Console.WriteLine("{0}: {1}", key, letterCount[key]);
            }

            /*foreach (char c in letterCount.Keys)
            {
                Console.WriteLine(c + ": " + letterCount[c]);
            }*/
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveLetterWords
{
    public class Program
    {
        public static List<string> fiveLetterWords(string userString)
        {
            List<string> wordsList = userString.Split().ToList();
            List<string> fiveLetters = new List<string>();
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i].Count(char.IsLetter) == 5)
                {
                    fiveLetters.Add(wordsList[i]);
                }
            }   
            return fiveLetters;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a message: ");
            string input = Console.ReadLine();
            //string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            Console.WriteLine(input);
            fiveLetterWords(input).ForEach(i => Console.WriteLine("{0}", i));
            
            Console.ReadLine();
        }
    }
}

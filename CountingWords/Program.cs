using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CountingWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string aliceLower = alice.ToLower();

            string[] wordList = Regex.Split(alice, @"\W");
            
            foreach (string s in wordList)
            {
                if (wordCount.Keys.Contains(s))
                {
                    wordCount[s] += 1;
                } else
                {
                    wordCount[s] = 1;
                }
            }

            List<string> list = wordCount.Keys.ToList();
            list.Sort();

            foreach (string key in list)
            {
                Console.WriteLine("{0}: {1}", key, wordCount[key]);
            }
            Console.ReadLine();
        }
    }
}

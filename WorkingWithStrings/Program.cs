using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // string myString = "Escape a \"character\" with a back-slash!";
            // string myString = "Add a new line\nwith back-slash 'n'.";
            // string myString = "Go to your c:\\ drive.";
            // string myString = @"Go to your c:\ drive."; // @ char allows back-slashes to not escape

            // string myString = String.Format("{0} = {1}", "First", "Second");

            // string myString = string.Format("Dollar Amount: {0:C}", 123.45); // 'C' formats with dollar value
            // string myString = string.Format("Display Number: {0:N}", 1234567890); // 'N' adds commas to display as written out number
            // string myString = string.Format("Percentage: {0:P}", .123); // 'P' displays as percentage
            // string myString = string.Format("Phone: {0:(###) ###-####}", 1234567890); // Shows as phone number

            // string myString = " I've made a huge mistake.  ";
            // myString = myString.Substring(6, 14); // Starts at 6th position of string. Or add second parameter to only show range of chars
            // myString = myString.ToUpper(); // Makes all caps
            // myString = myString.Replace(" ", "--"); // Replaces all spaces with two dashes
            // myString = myString.Remove(6, 14); // Removes range of chars
            /*
            myString = String.Format("Start Length: {0} -- End Length: {1}",
                myString.Length, 
                myString.Trim().Length); // Trim removes extra spaces before and after string
            */

            /*
            string myString = "";
            for (int i =0; i < 100; 1++)
            {
                myString += "--" + i.ToString();
            }
            */
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; 1++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}

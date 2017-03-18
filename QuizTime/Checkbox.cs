using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizTime
{
    public class Checkbox : Question
    {
        // private string[] choices;
        // private int[] correctChoices;

        Dictionary<bool, List<string>> answers;

        string question;

        public Checkbox(string question, Dictionary<bool, List<string>> answers)
        {
            this.answers = answers;
            this.question = question;
        }



        public override bool IsCorrect()
        {

            List<string> userinput = Console.ReadLine();

            if (userinput.Equals(answers[true]))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine();
        }
    }
}

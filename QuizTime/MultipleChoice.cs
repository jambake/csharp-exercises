using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizTime
{
    public class MultipleChoice : Question
    {

        private string[] choices;
        private int correctChoiceIndex;

        public MultipleChoice(string prompt, string[] choices, int correctChoiceIndex) : base(prompt)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizTime
{
    public abstract class Question
    {
        protected abstract bool IsCorrect();

        public abstract void DisplayQuestion();

        protected string Prompt;
        
        protected Question(string prompt)
        {
            Prompt = prompt;
        }
        

    }
}

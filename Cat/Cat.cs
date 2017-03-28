using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cats
{
    public abstract class Cat : IFeedable
    {
        public int Age { get; set; }
        public bool IsTired { get; set; } = false;
        public bool IsHungry { get; set; } = false;
        public double Weight { get; set; }

        // The biological Family for all cat species
        private string family = "Felidae";
        public string Family
        {
            get { return family; }
            private set { family = value; }
        }

        public Cat(double weight)
        {
            Weight = weight;
        }

        // A cat is rested and hungry after it sleeps
        public void Sleep()
        {
            IsTired = false;
            IsHungry = true;
        }

        // Eating makes a cat not hungry
        public void Eat()
        {

            // eating when not hungry makes a cat sleepy
            if (!IsHungry)
            {
                IsTired = true;
            }

            IsHungry = false;
        }

        public virtual void Noise()
        {
            Console.WriteLine("Meeeeeeooooowww!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOdemo3
{
    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {
            Weight = weight;
        }

        public override void MakeSound()
        {
            Bark();
        }

        private void Bark()
        {
            Console.WriteLine("bark...");
        }

        public override string ToString()
        {
            return $"Dogs weight: {Weight}";
        }
    }
}

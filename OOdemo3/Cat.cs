using System;
using System.Collections.Generic;
using System.Text;

namespace OOdemo3
{
    class Cat : Animal
    {
        public Cat() : base(4) //konstruktor
        {
        }

        public override void MakeSound()
        {
            Purr();
        }

        private void Purr()
        {
            Console.WriteLine("purr...");
        }

        public override string ToString()
        {
            return $"Cats weight: {Weight}";
        }
    }
}

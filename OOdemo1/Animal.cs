using System;
using System.Collections.Generic;
using System.Text;

namespace OOdemo1
{
    abstract class Animal
    {
        public Animal(double weight)
        {
            Weight = weight;
            MakeSound();
        }
        public double Weight { get; set; }

        public abstract void MakeSound();
    }

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
            return $"Weight: {Weight}";
        }
    }

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
    }
}

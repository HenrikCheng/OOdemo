using System;
using System.Collections.Generic;
using System.Text;

namespace OOdemo3
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

        public virtual void Eat(Animal animalToEat)
        {
            Weight += animalToEat.Weight;
        }
    }
}

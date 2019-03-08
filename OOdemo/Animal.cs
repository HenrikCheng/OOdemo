using System;
using System.Collections.Generic;
using System.Text;

namespace OOdemo
{
    abstract class Animal : Object, IEdible
    {
        public Animal(double weight, int tailLength)
        {
            MakeSound();
            Weight = weight;
        }

        public virtual void Eat(IEdible edible) //se virtual = override-able. Type substitution
        {
            //katten och hunden ärver eatmetoden
            this.Weight += edible.Weight;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"Weight: {Weight}";
        }

        public double Weight { get; set; }
    }

    interface IEdible
    {
        double Weight { get; set; }

    }
    class Grass : IEdible
    {
        public Grass(double weight)
        {
            Weight = weight;
        }
        public double Weight { get; set; }
    }

    class Cat : Animal
    {
        public Cat() : base(4, 5) //konstruktor
        {
        }
        public override void MakeSound()
        {
            Purr();
        }
        public void Purr()
        {
            Console.WriteLine("Purr...");
        }

        public override string ToString()
        {
            return $"Cat: {base.ToString()}";
        }
    }
    class Dog : Animal
    {
        public Dog(double weight) : base(weight, 10)
        {
        }

        public override void Eat(IEdible animalToEat) //dynamic binding
        {
            this.Weight += 0.8 * animalToEat.Weight;
        }

        public override void MakeSound()
        {
            Bark();
        }

        public void Bark()
        {
            Console.WriteLine("Bark...");
        }
        public override string ToString()
        {
            return $"Dog : {base.ToString()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOdemo4
{
    abstract class Animal : Object, IEdible
    {
        public Animal(double weight)
        {
            Weight = weight;
            Makesound();
        }
        public abstract void Makesound();
        public double Weight { get; set; }

        public virtual void Eat(IEdible animalToEat)
        {
            Weight += animalToEat.Weight;
        }
    }
    class Cat : Animal
    {
        public Cat() : base(4)
        {
        }

        public override void Makesound()
        {
            Console.WriteLine("purr...");
        }
    }
    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {
            Weight = weight;
        }

        public override void Eat(IEdible animalToEat)
        {
            this.Weight += animalToEat.Weight * 0.8;
        }

        public override void Makesound()
        {
            Console.WriteLine("bark...");
        }
    }
    class Grass : IEdible
    {
        public Grass(double weight)
        {
            Weight = weight;
        }
        public double Weight { get; set; }
    }
    interface IEdible
    {
        double Weight { get; set; }
    }
}

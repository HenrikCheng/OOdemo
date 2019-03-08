using System;
using System.Collections.Generic;

namespace OOdemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog(10));

            foreach (var animal in animals)
            {
                Console.Write("weight before lunch: ");
                Console.WriteLine(animal.Weight);
                var lunch = new Grass(1);
                animal.Eat(lunch);
                Console.Write("weight after lunch: ");
                Console.WriteLine(animal.Weight);
            }
        }
    }
}

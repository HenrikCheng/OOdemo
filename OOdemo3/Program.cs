using System;
using System.Collections.Generic;

namespace OOdemo3
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
                Console.WriteLine($"weight before meal: {animal}");
                var lunch = new Rat();
                animal.Eat(lunch);
                Console.WriteLine($"weight after meal: {animal}");
            }
        }
    }
}

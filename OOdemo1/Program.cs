using System;
using System.Collections.Generic;

namespace OOdemo1
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
                Console.WriteLine(animal.Weight);
            }
        }
    }
}

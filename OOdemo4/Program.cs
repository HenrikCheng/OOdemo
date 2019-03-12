using System;
using System.Collections.Generic;

namespace OOdemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.TextUtils.AnimateText(@"Episode IV
A NEW HOPE 
It is a period of civil war.
Rebel spaceships, striking
from a hidden base, have won
their first victory against
the evil Galactic Empire.

During the battle, Rebel
spies managed to steal secret
plans to the Empire's
ultimate weapon, the DEATH
STAR, an armored space
station with enough power to
destroy an entire planet.

Pursued by the Empire's
sinister agents, Princess
Leia races home aboard her
starship, custodian of the
stolen plans that can save
her people and restore
freedom to the galaxy.....", 100);

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

using OOdemo.Utils;
using System;
using System.Collections.Generic;

namespace OOdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TextUtils.AnimateText("Ettan", 150);
            //TextUtils.AnimateText("Tvåan", 150);

            //lösa utskrivning utan att använda static kräver mer kod = onödigt.
            //TextUtils tu = new TextUtils();
            //tu.AnimateText("Hello World!", 150);

            //TextUtils tu2 = new TextUtils();
            //tu.AnimateText("Tvåan!", 150);

            var animals = new List<Animal>(); //type substituion istället för cat och dog
            animals.Add(new Cat());
            animals.Add(new Dog(10));

            foreach (var animal in animals)
            {
                //var lunch = new Dog(1);
                var lunch = new Grass(1);
                animal.Eat(lunch);
                Console.WriteLine(animal);
            }
            //var cat = new Cat();
            //var dog = new Dog(10);

            //dog.Eat(cat); //dog ärver från animal

            //Console.WriteLine(dog.Weight);
            //foo funkar ej
        }
    }

}

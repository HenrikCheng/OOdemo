using System;
using System.Collections.Generic;
using System.Text;

namespace OOdemo3
{
    class Rat : Animal
    {
        public Rat() : base (1)
        {

        }
        public override void MakeSound()
        {
            psss();
        }

        private void psss()
        {
            Console.WriteLine("rat");
        }
    }
}

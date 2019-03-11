using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Utils
{
    public static class TextUtils
    {
        //fördröjning för text som skickas in i klassen
        public static void AnimateText(string text, int delay)
        {
            foreach (var c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
        //public void AnimateText(string text, int delay)
        //{
        //    foreach (var c in text)
        //    {
        //        Console.Write(c);
        //        Thread.Sleep(delay);
        //    }
        //    Console.WriteLine();
        //}
    }
}

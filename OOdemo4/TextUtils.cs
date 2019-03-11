using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOdemo4
{
    class TextUtils
    {
        public static void AnimateText(string text, int delay)
        {
            foreach (var c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    internal class MyDelegate
    {
        public delegate void delegateCallMethod(int a, int b);        

        public void add(int a, int b)
        {
            Console.WriteLine("Addition (" + a + " + " + b + ") = " + (a + b));
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("Subtraction (" + a + " - " + b + ") = " + (a - b));
        }
    }
}

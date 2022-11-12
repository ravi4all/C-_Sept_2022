using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Introduction
{
    class Overloading
    {
        void show(int x)
        {
            Console.WriteLine(x);
        }

        void show(char x)
        {
            Console.WriteLine(x);
        }

        void show(char x, int y)
        {
            Console.WriteLine(x);
        }

        public static void Main()
        {
            Overloading obj = new Overloading();
            obj.show(10);
            obj.show('b');
            obj.show('h',6);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Introduction
{
    abstract class AbstractDemo
    {
        public abstract void show();
        public void disp()
        {
            Console.WriteLine("Disp Method...");
        }
    }

    class X : AbstractDemo
    {
        public override void show()
        {
            Console.WriteLine("Show Called...");
        }

        public static void Main()
        {
            /*AbstractDemo obj = new AbstractDemo();*/
            X obj = new X();
            obj.show();
            obj.disp();
        }
    }
}

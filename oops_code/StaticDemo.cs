using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Introduction
{
    class StaticDemo
    {
        /*Class Variables*/
        static int counter = 100;
        /*Instance Variables*/
        int id;
        string name;
        int age;
        public StaticDemo(string name, int age)
        {
            counter++;
            this.id = counter;
            this.name = name;
            this.age = age;
        }
        public static void Main()
        {
            StaticDemo obj = new StaticDemo("Ram", 40);
            Console.WriteLine("Id : {0}",obj.id);
            Console.WriteLine("Name : {0}", obj.name);
            Console.WriteLine("Age : {0}", obj.age);

            StaticDemo obj_2 = new StaticDemo("Shyam", 30);
            Console.WriteLine("Id : {0}", obj_2.id);
            Console.WriteLine("Name : {0}", obj_2.name);
            Console.WriteLine("Age : {0}", obj_2.age);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Introduction
{
    class Person
    {
        public string name;
        public int age;

        public void showPerson()
        {
            Console.WriteLine("Show Person Called...");
        }

        public virtual void calcROI()
        {
            Console.WriteLine("ROI is 7%");
        }
    }

    class Employee : Person
    {
        public void showEmp()
        {
            Console.WriteLine("Show Emp Called...");
        }

        public override void calcROI()
        {
            Console.WriteLine("ROI is 8%");
        }
    }

    class Student : Person
    {
        public void showStudent()
        {
            Console.WriteLine("Show Student Called...");
        }

        /*public override void calcROI()
        {
            Console.WriteLine("ROI is 6%");
        }*/

        new public void calcROI()
        {
            base.calcROI(); // calling parent class ROI
            Console.WriteLine("ROI is 6%");
        }
    }
    class InheritanceDemo
    {
        // Polymorphic Call
        static void caller(Person person)
        {
            person.showPerson();
            person.calcROI();
            // Downcasting - converting type of object back to
            // child class
            if(person is Employee)
            {
                Employee e = (Employee)person;
                e.showEmp();
            }
            else
            {
                Student s = (Student)person;
                s.showStudent();
            }
        }
        public static void Main()
        {
            /*Employee emp = new Employee();
            emp.showPerson();
            emp.showEmp();
            emp.calcROI();

            Student student = new Student();
            student.showPerson();
            student.showStudent();
            student.calcROI();*/

            // Upcasting - create object of child class
            // but type of object will be parent class
            /*Person person = new Employee();
            person.showPerson();
            person.showEmp();
            person.calcROI();

            person = new Student();
            person.showPerson();
            person.showStudent();
            person.calcROI();*/

            caller(new Employee());
            caller(new Student());
        }
    }
}

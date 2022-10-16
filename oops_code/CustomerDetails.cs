using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Introduction
{
    class CustomerDetails
    {
        public string name;
        public double balance;
        public int acc_no;

        /*Default Constructor*/
        CustomerDetails():this(null,0,0)
        {
            Console.WriteLine("This is default Constructor...");
        }

        /*Parameterized Constructor*/
        CustomerDetails(string name, double balance, int acc_no)
        {
            this.name = name;
            this.balance = balance;
            this.acc_no = acc_no;
        }

        public void takeInput(string name, double balance, int acc_no)
        {
            if(balance < 0)
            {
                Console.WriteLine("Invalid Balance...");
            }
            else
            {
                this.name = name;
                this.balance = balance;
                this.acc_no = acc_no;
            }
            
        }

        public void showCustomer()
        {
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Acc No : {0}", acc_no);
            Console.WriteLine("Balance : {0}", balance);
        }

        public static void Main()
        {
            // calling default constructor
            //CustomerDetails ram_1 = new CustomerDetails();

            // calling parameterized constructor
            CustomerDetails ram = new CustomerDetails("Ram", 67544.00, 312312);
            /*ram.name = "Ram Sharma";
            ram.acc_no = 3353759;
            ram.balance = 45000.00;*/
            /*ram.takeInput("Ram", 67544.00, 312312);*/
            ram.showCustomer();

            // calling default constructor
            //CustomerDetails shyam = new CustomerDetails();

            // calling parameterized constructor
            CustomerDetails shyam = new CustomerDetails("Shyam", 50000.00, 31231212);
            /*shyam.name = "Shyam Sharma";
            shyam.acc_no = 3355129;
            shyam.balance = 55000.00;*/
            /*shyam.takeInput("Shyam", 50000.00, 31231212);*/
            shyam.showCustomer();
        }
    }
}

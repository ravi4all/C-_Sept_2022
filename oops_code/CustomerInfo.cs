using System;
using System.Collections.Generic;
using System.Text;

/*SRP = Single Responsibility Principle*/

namespace OOPS_Introduction
{
    class CustomerInfo
    {
        public string name;
        private double balance;
        protected int acc_no;
        /*internal could be accessed only within assembly*/
        /*assembly is a collection of types (classes, interface) and resources*/
        internal double fees;
        protected internal string address;
        /*could be accessed in same class as well as inherited class*/
        private protected long phone;

        /*Default Constructor*/
        public CustomerInfo() : this(null, 0, 0)
        {
            Console.WriteLine("This is default Constructor...");
        }

        /*Parameterized Constructor*/
        public CustomerInfo(string name, double balance, int acc_no)
        {
            this.name = name;
            this.balance = balance;
            this.acc_no = acc_no;
        }

        public void takeInput(string name, double balance, int acc_no)
        {
            if (balance < 0)
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
    }

    class CustomerUpdate : CustomerInfo
    {
        void showUpdate()
        {
            /*CustomerInfo o1 = new CustomerInfo("Akash",56000.00, 9086431);*/
            Console.WriteLine("Name is : {0}", name);
            Console.WriteLine("Account No is : {0}",acc_no);
        }
    }
}

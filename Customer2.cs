using System;
using System.Collections.Generic;
using System.Text;

/*DRY - Donot Repeat Yourself*/

namespace OOPS_Introduction
{
    class Customer2
    {
        public string name;
        public double balance;
        public int acc_no;

        public void showCustomer()
        {
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Acc No : {0}", acc_no);
            Console.WriteLine("Balance : {0}", balance);
        }

    }
}

using System;

namespace OOPS_Introduction
{
    class Customer
    {
        string name;
        double balance;
        int acc_no;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Customer ram = new Customer();*/
            Customer2 ram = new Customer2();
            ram.name = "Ram Sharma";
            ram.acc_no = 3353759;
            ram.balance = 45000.00;
            ram.showCustomer();
            /*Console.WriteLine("Name : {0}", ram.name);
            Console.WriteLine("Acc No : {0}", ram.acc_no);
            Console.WriteLine("Balance : {0}", ram.balance);*/

            /*Customer shyam = new Customer();*/
            Customer2 shyam = new Customer2();
            shyam.name = "Shyam Verma";
            shyam.acc_no = 113353759;
            shyam.balance = 40000.00;
            shyam.showCustomer();
            /*Console.WriteLine("Name : {0}", shyam.name);
            Console.WriteLine("Acc No : {0}", shyam.acc_no);
            Console.WriteLine("Balance : {0}", shyam.balance);*/
        }
    }
}

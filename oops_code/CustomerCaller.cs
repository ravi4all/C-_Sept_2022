using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Introduction
{
    class CustomerCaller
    {
        public static void Main()
        {
            CustomerInfo c1 = new CustomerInfo("Ram", 67544.00, 312312);
            c1.showCustomer();
            c1.name = "Raman";
            c1.showCustomer();
            /*c1.balance = 4000.00;*/

            CustomerInfo c2 = new CustomerInfo("Shyam", 67544.00, 312312);
            c2.showCustomer();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

using OOPS_Introduction;

namespace AnotherNameSpace
{
    class AssembleDemo:CustomerInfo
    {
        void showUpdate()
        {
            CustomerInfo o1 = new CustomerInfo("Akash", 56000.00, 9086431);
            /*because name is public*/
            Console.WriteLine("Name is : {0}", o1.name);
            /*because fees is internal*/
            Console.WriteLine("Fees is : {0}", o1.fees);
            Console.WriteLine("Address is : {0}",address);

        }
    }
}

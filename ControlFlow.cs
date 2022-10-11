using System;

namespace Condition {
    class ControlFlow {
        static void Main(string[] args) {
            int n1 = 10, n2 = 14, n3 = 34;
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("{0} is greatest...", n1);
            }
            else if (n2 > n3 && n2 > n1)
            {
                Console.WriteLine("{0} is greatest...", n2);
            }
            else
            {
                Console.WriteLine("{0} is greatest...", n3);
            }
        }
    }
}
using System;
namespace OpertorsDemo
{
    class Operators {
        static void Main(string[] args) {
            // - Arithmetic Operator
            // +,-,/,*,%
            int x = 12;
            int y = 7;
            object result;
            result = x + y;
            Console.WriteLine("Addition is : " + result);

            result = x - y;
            Console.WriteLine("Sub is : " + result);

            result = x / y;
            Console.WriteLine("Div is : " + result);

            result = x * y;
            Console.WriteLine("Mul is : " + result);

            result = x % y;
            Console.WriteLine("Rem is : " + result);

            // - Assignment Operator
            // =, +=, -=, /=, *=, %=, <<=, >>=, &=, ^=, |=
            
            int y1 = 12;
            y1 += 5;    // y1 = y1 + 5;
            y1 -= 5;    // y1 = y1 - 5;
            y1 /= 5;    // y1 = y1 / 5;
            y1 *= 5;    // y1 = y1 * 5;
            y1 %= 5;    // y1 = y1 % 5;

            // - Relational Operator
            // ==, !=, <, >, <=, >=

            int n1 = 10;
            int n2 = 10;
            result = n1 == n2;
            Console.WriteLine("Comparison is : " + result);
            result = n1 > n2;
            Console.WriteLine("Comparison is : " + result);
            result = n1 < n2;
            Console.WriteLine("Comparison is : " + result);
            result = n1 >= n2;
            Console.WriteLine("Comparison is : " + result);
            result = n1 <= n2;
            Console.WriteLine("Comparison is : " + result);
            result = n1 != n2;
            Console.WriteLine("Comparison is : " + result);

            // - Logical Operator
            // &&, ||, !
            int m1 = 20, m2 = 40, m3 = 22;
            result = m1 > m2 && m1 > m3;
            Console.WriteLine("Result is : "+ result);

            result = m2 > m3 && m2 > m1;
            Console.WriteLine("Result is : "+ result);

            result = m1 > m2 || m2 > m3;
            Console.WriteLine("Result is : "+ result);

            result = 5 & 1;
            Console.WriteLine("Result is : " + result);

            result = 5 | 1;
            Console.WriteLine("Result is : " + result);

            result = 5 ^ 1;
            Console.WriteLine("Result is : " + result);

            string res = (m1 > m2) ? "M1 is greater" : "M2 is greater";
            Console.WriteLine("Result is : " + res);

            // m1++;
            // Console.WriteLine("M1 is : " + m1++);

            // m1--;
            // Console.WriteLine("M1 is : " + m1--);

            Console.WriteLine("M1 is : " + ++m1);
            
            Console.WriteLine("M1 is : " + --m1);


        }
    }
}
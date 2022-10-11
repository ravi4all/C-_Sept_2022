using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("I is : {0}", i);
            }*/

            /*int num = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }*/

            /*for(int i = 0, j = 0; i+j <= 5; i++,j++)
            {
                Console.WriteLine("i : {0} and j : {1}", i, j);
            }*/

            /*for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 10;
            while (i > 0)
            {
                Console.WriteLine("I is {0}", i);
                i--;
            }*/

            /*int i = 1;
            int sum = 0;
            while(i <= 5)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum is {0}", sum);*/

            /*int i = 11;
            int sum = 0;
            do
            {
                sum += i;
                i++;
            } while (i <= 10);
            Console.WriteLine("Sum is {0}", sum);*/

            /*int num = 25;
            bool prime = true;
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if(prime)
            {
                Console.WriteLine("{0} is prime", num);
            }
            else
            {
                Console.WriteLine("{0} is not prime", num);
            }


            for(int i = 0; i < 10; i++)
            {
                if(i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }*/


            // Foreach
            /*int[] arr = new int[] { 2, 1, 4, 6, 2, 5 };*/
            /*for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/

            /*foreach(int e in arr)
            {
                Console.WriteLine(e);
            }*/


            char ch;
            double first, second, result;

            Console.WriteLine("Enter fnum num : ");
            first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter snum num : ");
            second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your choice [+,-,/,x] : ");
            /*ch = Convert.ToInt32(Console.ReadLine());*/
            ch = (char)Console.Read();

            switch (ch)
            {
                case '+':
                    Console.WriteLine("Pressed 1...");
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;
                case '-':
                    Console.WriteLine("Pressed 2...");
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;
                case '/':
                    Console.WriteLine("Pressed 3...");
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;
                case 'x':
                    Console.WriteLine("Pressed 4...");
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;
            }


            string msg = "HI";
            msg.ToLower();

            if(msg == "hi")
            {
                Console.WriteLine("Hello User...");
            }
            else if(msg == "date")
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
            }
            else if(msg == "bye")
            {
                Console.WriteLine("Bye User...");
            }
            else
            {
                Console.WriteLine("I don't understand");
            }


        }
    }
}

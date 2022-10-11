using System;
namespace IO
{
    class BasicIO {
        static void Main(string[] args) {
            // Console.Write("Ok Fine...");
            // Console.WriteLine("Hello how are you..?");
            string name;
            // int name;
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            // name = Console.Read();
            // ReadLine, Read, ReadKey

            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
            
            Console.WriteLine("Welcome : " + name);

            Console.WriteLine("Enter first num : ");
            int fnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first num : ");
            int snum = Convert.ToInt32(Console.ReadLine());

            int res = fnum + snum;
            Console.WriteLine("Sum : " + res);

            // Implicit Type Casting
            int i = 10;
            double d = i;   // automatic casting : int to double

            int j = (int)d; // manual casting : double to int

        }
    }
}
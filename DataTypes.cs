using System;
namespace DataTypesUses
{
    class DataTypes {
        static void Main() {
            int x = 12012122;
            byte b = 255;
            short s = 1214;

            long l1 = 231322;

            sbyte sb = 127;
            uint ui = 88;
            ulong ul = 121;

            float f = 4.6f;
            double d = 12.3;
            decimal dec = 234.32m;
            
            char c = 'A';

            Console.WriteLine("Signed {0} ",sb);
            sb++;
            Console.WriteLine("Signed {0} ",sb);

            Console.WriteLine("UnSigned {0} ",b);
            b++;
            Console.WriteLine("UnSigned {0} ",b);

            // bool b = true;

            string name = "Ram";
            name += " Sharma";

            object obj;
            obj = 124;
            Console.WriteLine(obj.GetType());

            unsafe
            {
                int y1 = 12;
                // storing address of y1 in ptr variable
                int* ptr = &y1;
                Console.WriteLine("{0}, {1}",y1, (int)ptr);
            }
        }
    }
}
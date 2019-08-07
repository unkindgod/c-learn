using System;

namespace classwork_4_1
{
    class Program
    {
        static void Main()
        {
            int a = 18;
            int b = a++;

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
        }
    }
}

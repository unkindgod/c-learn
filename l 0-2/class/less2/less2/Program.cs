using System;

namespace less2
{
    class Program
    {
        static void Main()
        {
            int a; //declare
            a = 10; //setting a value

            int b = 20;
            string name = "This is string";


            Console.WriteLine(name);
            Console.WriteLine($"{a} * {b} = {a * b}");

            var newA = 10;
            var newB = "This is another string";

            Console.WriteLine($"{newA} {newB}");

            byte maximumByte = 255;
            sbyte maximumSignedByte = SByte.MaxValue;
            Console.WriteLine($"{maximumByte}, {maximumSignedByte}");


        }
    }
}

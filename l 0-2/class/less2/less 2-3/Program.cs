using System;
using System.IO;

namespace less_2_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a number:");

            string typeNumber = Console.ReadLine();
            int integerNumber = int.Parse(typeNumber);

            Console.WriteLine(integerNumber+integerNumber);
            Console.WriteLine(integerNumber*integerNumber);


        }
    }
}

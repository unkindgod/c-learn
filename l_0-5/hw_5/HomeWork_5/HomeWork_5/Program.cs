using System;
using System.IO;

namespace HomeWork_5
{
    class Program
    {
        const int circle = 1;
        const int triangle = 2;
        const int rectangle = 3;

        public static void Main()
        {
            Console.WriteLine("What type of figure you want: 1 - a Circle, 2 - triangle, 3 - rectangle");
            int countConvert = int.Parse(Console.ReadLine());
            switch (countConvert)
            {
                case 1:
                    Console.WriteLine("");
                    break; 
            }
        }
    }
}

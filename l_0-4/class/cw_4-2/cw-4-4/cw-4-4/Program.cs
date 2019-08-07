using System;

namespace cw_4_4
{
    class Program
    {
        enum WindDirection
        {
            None = 0,
            North = 1,
            East = 1 << 1,
            South = 1 << 2,
            West = 1 << 3
        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = int.MaxValue;

            //int c = a | b;

            Console.WriteLine(ToBynaryString(a));
            Console.WriteLine(ToBynaryString(a | b));
            Console.WriteLine(ToBynaryString(a & b));
            Console.WriteLine(ToBynaryString(a ^ b));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int shiftSample = 7;
            Console.WriteLine(ToBynaryString(shiftSample));
            Console.WriteLine(ToBynaryString(shiftSample << 1));
            Console.WriteLine(ToBynaryString(shiftSample << 2));
            Console.WriteLine(ToBynaryString(shiftSample << 7));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(ToBynaryString((int)WindDirection.North));
            Console.WriteLine(ToBynaryString((int)WindDirection.East));
            Console.WriteLine(ToBynaryString((int)WindDirection.South));
            Console.WriteLine(ToBynaryString((int)WindDirection.West));

            WindDirection wd = WindDirection.East | WindDirection.North;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(ToBynaryString((int)wd));

            Console.WriteLine(string.Join(" \t ", new[] { 1, 2, 4, 6}));
        }
        static string ToBynaryString(int a)
        {
            return Convert.ToString(a, 2).PadLeft(32, '0') + $" ({a})";
        }
    }
}

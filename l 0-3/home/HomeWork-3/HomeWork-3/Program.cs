using System;
using System.Threading;

namespace HomeWork_3
{
    class Program
    {
        static void Main()
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] y = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            for (int i = 1; i < 11; i++)
            {
                for (int o = 1; o < 11; o++)
                {
                    Console.WriteLine(i * o);
                }
            }
            Console.ReadKey();    
        }
    }
}

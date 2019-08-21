using System;
using System.Collections.Generic;

namespace cw_8_1_1
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>
            {
                10,
                20,
                30,
                40
            };

            Console.WriteLine(string.Join(", ", intList));
            //10 20 30 40
        }
    }
}

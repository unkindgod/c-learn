using System;

namespace cw_3_3
{
    class Program
    {
        static void Main()
        {
            // string[] names = new string[5];

            //names[0] = "Andrey";
            //names[1] = "Maria";
            //names[2] = "Alexander";
            //names[3] = "Eugenia";
            //names[4] = "Sergey";

            string[] names =
                (
                "Andrey",
                "Maria",
                "Alexander",
                "Eugenia",
                );
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                Console.WriteLine();
            }
        }
    }
}

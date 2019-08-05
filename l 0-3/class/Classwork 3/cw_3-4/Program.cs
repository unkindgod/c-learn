using System;
using System.Threading;
namespace cw_3_4
{
    class Program
    {
        static void Main()
        {
            string[] trees = new string[3];

            trees[0] = "ash";
            trees[1] = "linden";
            trees[2] = "cedar";

            int[] ages = new int[3];

            ages[0] = 32;
            ages[1] = 24;
            ages[2] = 43;

            for (int i = 0; i < trees.Length; i++)
            {
                Console.WriteLine($"{trees[i]} age: {ages[i]}");
            }
        }
    }
}

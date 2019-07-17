using System;

namespace less_2_2
{
    class Program
    {
        static void Main()
        {

            int sun = 1_321_123;
            long universe = sun;

            sun = (int)universe;

            float f = sun;

            sun = (int)f;


            string valueOfSun = sun.ToString();
            Console.WriteLine(valueOfSun);
            //Console.WriteLine(sun);
            Console.WriteLine("Enter number: ");
            string value = Console.ReadLine();
            int integerValue = int.Parse(value);

            Console.WriteLine(value + value);
            Console.WriteLine(integerValue +integerValue);

        }
    }
}

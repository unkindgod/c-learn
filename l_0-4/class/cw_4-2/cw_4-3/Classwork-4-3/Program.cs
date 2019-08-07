using System;

namespace Classwork_4_3
{
    class Program
    {
        enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };
        enum Month : byte
        {
            Jan,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        };
        static void Main()
        {
          Day today = Day.Monday;
            int dayNumber = (int)today;
            Console.WriteLine("{0} is a day number #{1}", today, dayNumber);
        }
    }
}

using System;

namespace cw_3_2
{
    class Program
    {
        static void Main()
        {
            int? i;
            i = null;

            Console.WriteLine(i.HasValue);
            Console.WriteLine(i.Value);
        }
    }
}

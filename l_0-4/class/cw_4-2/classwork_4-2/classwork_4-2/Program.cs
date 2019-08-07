using System;
using System.Text;

namespace classwork_4_2
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Укажите переменную a:");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Укажите переменную h:");
            var h = double.Parse(Console.ReadLine());

            double s1 = 3 * a * h;
            Console.WriteLine(s1);
            double s2 = 3 / 2 * a * (a * Math.Sqrt(3) + 2 * h);
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}

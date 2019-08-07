using System;
using System.Text;
using System.Threading;

namespace HomeWork_2
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введите первое число:");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Какую операцию необходимо выполнить (+, -, *, /)?:");
            var c = char.Parse(Console.ReadLine());
            double total;

            if (c == '+')
            {
                total = a + b;
                Console.WriteLine($"Сумма равна: {total}");
            }
            else if (c == '-')
            {
                total = a - b;
                Console.WriteLine($"Разность равна: {total}");
            }
            else if (c == '*')
            {
                total = a * b;
                Console.WriteLine($"Умножение равно: {total}");
            }
            else if (c == '/')
            {
                total = a / b;
                Console.WriteLine($"Деление равно: {total}");
            }
            Console.ReadKey();
        }
    }
}

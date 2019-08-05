using System;

namespace Classwork_3
{
    class Program
    {
        static void Main()
        {
            object name = "Sergey";
            object age = 29;
            object height = 1.78;

            // int length1 = name.Lenght;
            int length2 = ((string)name).Length;

            Console.WriteLine(length2);
        }
    }
}

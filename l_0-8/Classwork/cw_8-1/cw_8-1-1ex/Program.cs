using System;
using System.Collections.Generic;

namespace cw_8_1_1ex
{
    class Program
    {
        static void Main()
        {
            const string endWord = "stop";

            List<double> values = new List<double>();
            while(true)
            {
                string input = Console.ReadLine();
                if (input == endWord)
                {
                    break;
                }

                double value = double.Parse(input);
                values.Add(value);
            }

            double summOfValues = 0;
            //double averegeValues = 0;

            foreach(double value in values)
            {
                summOfValues += value;
            }

            double averegeValues = summOfValues / values.Count;
        }
    }
}

using System;
using System.Collections.Generic;

namespace cw_8_2
{
    class Program
    {
        static void Main()
        {
            //Dictionary<string, string> countries = new Dictionary<string, string>(5);

            //countries.Add("1", "Russia");
            //countries.Add("3", "Great Britain");
            //countries.Add("2", "USA");
            //countries.Add("4", "France");
            //countries.Add("5", "China");

            //foreach (KeyValuePair<string, string> keyValue in countries)
            //{
            //    Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            //}
            ////getting elements by key
            //string country = countries["4"]; // #4 is "France"
            ////changing of the value by index
            //countries["4"] = "Spain"; // #4 has changed, now it "Spain"
            ////removing by key
            //countries.Remove("2"); // now "Great Britain" deleted

            //Console.WriteLine("The amazing country {0}", countries["5"]);

            //Example

            const string endWord = "exit";

            Stack<string> plates = new Stack<string>();
            plates.Push("one");
            plates.Push("two");
            plates.Push("tree");
            plates.Push("4");
            plates.Push("5");

            Console.WriteLine("Type \"wash\" if you wont washing plate");
            Console.WriteLine("Type \"dry\" if you wont drying plate");
            Console.WriteLine("Type \"exit\" if you wont close a program");

            foreach (string plate in plates)
            {
                Console.WriteLine(plate);
            }

            while (plates.Count > 0)
            {
                string n = plates.Pop();

            }

        }
    }
}

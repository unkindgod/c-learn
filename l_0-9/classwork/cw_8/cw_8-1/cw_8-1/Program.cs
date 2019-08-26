using System;
using System.Diagnostics;

namespace cw_8_1
{
    class Program
    {
        static void Main()
        {
            const int length = 50000;
            const int maxValue = int.MaxValue;

            Stopwatch sw = new Stopwatch();

            int[] arr = GetInitialArray(length, maxValue);

            //WriteOutArrayValues(arr, "Initial array: ");

            //DateTime dt = DateTime.Now;
            sw.Start();
            var sortedArr = BubbleSort(arr);
            sw.Stop();
            Console.WriteLine($"Bubble sort done in {sw.ElapsedMilliseconds} ms");
            //DateTime dt2 = DateTime.Now;
            
            //WriteOutArrayValues(sortedArr, "Sorted array: ");

            sw.Restart();
            int[] sortedArr2 = SystemSort(arr);
            sw.Stop();
            Console.WriteLine($"System sort done in {sw.ElapsedMilliseconds} ms");

            //WriteOutArrayValues(sortedArr2, "Another sorted: ");
        }
        
        public static int[] GetInitialArray(int arrayLenght, int maxElementValue)
        {
            var arr = new int[arrayLenght];
            var rnd = new Random();

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(maxElementValue);
            }

            return arr;
        }

        public static void WriteOutArrayValues(int[] arr, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(string.Join(", ", arr) + "\n");
        }

        public static int[] BubbleSort(int[] inputArr)
        {
            //int[] arr = new int[inputArr.Length];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = inputArr[i];
            //}
            int[] arr = (int[])inputArr.Clone();

            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1 - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return arr;
        }

        private static int[] SystemSort(int[] arr)
        {
            int[] a = (int[])arr.Clone();
            Array.Sort(a);
            return a;
        }

        public static void UpdateValue(ref int a)
        {
            a = a + 1;
            Console.WriteLine(a);
        }
    }
}

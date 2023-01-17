using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstLength = items.Length;
            // 1 2 3
            // => 3 5
            // => 8
            //length - 1 => condense
            for (int i = 0; i < firstLength -1; i++)
            {
                int[]condense = new int[items.Length - 1];

                for (int j = 0; j < items.Length - 1; j++)
                {
                    condense[j] = items[j] + items[j + 1];
                }

                items = condense;
            }

            Console.WriteLine(items[0]);
        }
    }
}

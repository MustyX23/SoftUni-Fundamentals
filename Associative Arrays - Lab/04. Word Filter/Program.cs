using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> keyValuePairs = new SortedDictionary<double, int>();

            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (!keyValuePairs.ContainsKey(number))
                {
                    keyValuePairs.Add(number, 1);
                }
                else
                {
                    keyValuePairs[number]++;
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index = firstArray.Zip(secondArray, (x, y) => x == y).ToList().IndexOf(false);

            if (index >= 0)
            {
                Console.WriteLine($"Arrays are not equal. Found difference at {index} index ");
            }
            else
            {
                Console.WriteLine($"Arrays are equal.");
            }
        }
    }
}

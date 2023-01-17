using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstItems = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondItems = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < firstItems.Length; i++)
            {
                if (firstItems[i] == secondItems[i])
                {
                    sum += firstItems[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

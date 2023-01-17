using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];

                //Pass all nums to its right.
                bool isTopInteger = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];
                    if (nextNum >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write($"{currNum} ");
                }

                //Pass through all nums to its left.
                //for (int k = 0; k < i; k++)
                //{

                //}
            }
        }
    }
}

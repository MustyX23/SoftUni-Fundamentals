﻿using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = n * n;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + i - 1);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

﻿using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(@base, power));
        }

        static double MathPower(double @base, double power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result = result * @base;
            }
            return result;
        }
    }
}

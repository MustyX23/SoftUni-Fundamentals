using System;
using System.Collections.Generic;
using System.Drawing;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float food = float.Parse(Console.ReadLine()) * 1000;
            float hay = float.Parse(Console.ReadLine()) * 1000;
            float cover = float.Parse(Console.ReadLine()) * 1000;
            float guineaWeight = float.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                food -= 300;
                if (i % 2 == 0)
                {
                    float hayAmount = food * 0.05f;
                    hay -= hayAmount;
                }
                if (i % 3 == 0)
                {
                    cover -= guineaWeight * 0.3333f;
                }
            }

            float foodKg = food / 1000;
            float hayKg = hay / 1000;
            float coverKg = cover / 1000;

            if (foodKg > 0 && hayKg > 0 && coverKg > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKg:f2}, Hay: {hayKg:f2}, Cover: {coverKg:f2}.");
            }
            else if (foodKg <= 0 || hayKg <= 0 || coverKg <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }

        }
    }
}

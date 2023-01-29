using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] divs = { 10, 7, 6, 3, 2 };

            for (int i = 0; i < divs.Length; i++)
            {
                int divisibleNumber = divs[i];

                if (number % divisibleNumber == 0)
                {
                    Console.WriteLine($"The number is divisible by {divisibleNumber}");
                    return;
                }
            }
                
            Console.WriteLine("Not divisible");
        }
    }
}

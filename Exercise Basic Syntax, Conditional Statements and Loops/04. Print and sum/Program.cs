using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                
                sum += i;
                Console.Write($"{i} ");                
            }

            Console.WriteLine($"\nSum: {sum}");
        }
    }
}

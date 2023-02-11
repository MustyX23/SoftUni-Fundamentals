using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            NxN(n);
        }

        static void NxN(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{number} ");
                for (int j = 0; j < number - 1; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}

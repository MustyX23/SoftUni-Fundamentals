using System;
using System.Security.Cryptography;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += (int)char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

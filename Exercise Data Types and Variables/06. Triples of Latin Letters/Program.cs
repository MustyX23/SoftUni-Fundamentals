using System;
using System.Security.Cryptography;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 97; a < 97 + n; a++)
            {
                for (int b = 97; b < 97 + n; b++)
                {
                    for (int c = 97; c < 97 + n; c++)
                    {
                        Console.WriteLine($"{(char)a}{(char)b}{(char)c}");
                    }
                }
            }
        }
    }
}

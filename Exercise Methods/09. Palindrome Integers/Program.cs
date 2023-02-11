using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 10;
            Console.WriteLine(isValid(a, b));
            
        }
        static bool isValid(int a, int b)
        {
            return a == b;
        }
    }
}

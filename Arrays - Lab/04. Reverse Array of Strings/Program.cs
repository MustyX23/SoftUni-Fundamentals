using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string elements = Console.ReadLine();
            string[]items = elements.Split();

            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.Write($"{items[i]} ");
            }
        }
    }
}

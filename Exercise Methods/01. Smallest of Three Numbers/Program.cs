using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(Smallest_of_Three_Numbers(first, second, third));
        }

        static int Smallest_of_Three_Numbers(int first, int second, int third)
        {
            if (first < second && first < third)
            {
                return first;
            }
            else if (second < first && second < third)
            {
                return second;
            }
            else 
            { 
                return third; 
            }
        }
    }
}

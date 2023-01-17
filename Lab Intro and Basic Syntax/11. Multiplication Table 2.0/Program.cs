using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            int bigMultiplier = input * start;

            for (int i = start; i <= 10; i++)
            {
                int result = start * i;
                Console.WriteLine($"{input} X {i} = {result}");                
            }
            if (start > 10)
            {
                Console.WriteLine($"{input} X {start} = {bigMultiplier}");
            }
            
        }
    }
}

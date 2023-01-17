using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                num[i] = value;
            }

            for (int i = num.Length -1 ; i >= 0; i--)
            {
                Console.Write($"{num[i]} ");
            }

        }
    }
}

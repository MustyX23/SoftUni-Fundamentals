using System;
using System.Numerics;

class NumberToAlphabet
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');

            long leftNumber = long.Parse(numbers[0]);
            long rightNumber = long.Parse(numbers[1]);

            
            if (leftNumber > rightNumber)
            {
                int sum = 0;
                foreach (char c in numbers[0])
                {
                    if (Char.IsDigit(c))
                    {
                        sum += (c - '0');
                    }
                }
                Console.WriteLine(sum);
            }
            else if (leftNumber < rightNumber)
            {
                int sum = 0;
                foreach (char c in numbers[1])
                {
                    if (Char.IsDigit(c))
                    {
                        sum += (c - '0');
                    }
                }
                Console.WriteLine(sum);
            }
        }
            
    }
}

using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];

            int sum = 0;

            int min = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < min; i++)
            {
                sum += Multiplier(firstString[i], secondString[i]);                             
            }

            string longestWord = firstString;

            if (firstString.Length < secondString.Length)
            {
                longestWord = secondString;
            }

            for (int i = min; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
                //(int)longestWord[i];
            }

            Console.WriteLine(sum);
        }

        static int Multiplier(char first, char second)
        {
            return first * second;
        }
    }
}

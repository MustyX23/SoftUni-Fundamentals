using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharactersInRange(firstChar, secondChar);
        }

        static void CharactersInRange(char firstChar, char secondChar)
        {
            if (secondChar < firstChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            for (int i = (int)firstChar + 1; i < (int)secondChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
            
        }
    }
}

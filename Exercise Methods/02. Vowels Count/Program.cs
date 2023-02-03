using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(GetVowelsCount(text));
        }

        static int GetVowelsCount(string text)
        {
            int count = 0;
            foreach (var c in text)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    count++;
                }
            }
            return count;
        }
    }
}

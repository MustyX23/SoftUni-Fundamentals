using System;

namespace _05._Digits__Letters_and_Other__common_way_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            foreach (var item in text)
            {
                if (Char.IsDigit(item))
                {
                    digits += item;
                }
                else if (Char.IsLetter(item))
                {
                    letters += item;
                }
                else 
                {
                    other += item;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);

        }
    }
}

using System;
using System.Text;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using StringBuilder Class:

            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            var letters = new StringBuilder();
            var characters = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (Char.IsDigit(c))
                {
                    digits.Append(c);
                }
                else if (Char.IsLetter(c))
                {
                    letters.Append(c);
                }
                else
                {
                    characters.Append(c);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);

        }
    }
}

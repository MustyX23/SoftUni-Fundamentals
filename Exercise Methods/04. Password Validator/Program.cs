using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (ValidCharacters(input) && LettersAndDigits(input)
                &&MustHaveTwoDigits(input))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidCharacters(input))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!MustHaveTwoDigits(input))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
                if (!LettersAndDigits(input))
                {
                    Console.WriteLine("Password must consist only of letters and digits");                   
                }
            }
        }
        static bool ValidCharacters(string input)
        {
            return input.Length >= 6 && input.Length <= 10;
        }
        static bool LettersAndDigits(string input)
        {
            return input.All(char.IsLetterOrDigit);
        }
        static bool MustHaveTwoDigits(string input)
        {
            int digitCount = input.Count(char.IsDigit);
            return digitCount >= 2;
        }
    }
}

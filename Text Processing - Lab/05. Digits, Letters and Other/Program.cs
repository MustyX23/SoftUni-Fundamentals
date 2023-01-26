using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uses the 'Where' method from the System.Linq
            //namespace to filter the characters
            //in the input string that are digits and then converts the result
            //to an array of characters, and then use the new keyword to create a new string object
            //with the filtered characters.

            string input = Console.ReadLine();

            //digits
            string digits = new string(input.Where(Char.IsDigit).ToArray());
    
            //letters
            string letters = new string(input.Where(Char.IsLetter).ToArray());

            //characters
            string characters = new string(input.Where(x => !Char.IsLetter(x) && 
            !Char.IsDigit(x)).ToArray());

            //output
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}

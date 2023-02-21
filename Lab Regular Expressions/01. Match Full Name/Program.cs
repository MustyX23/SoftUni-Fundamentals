using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //It consists of two words.
            //o Each word starts with a capital letter.
            //o After the first letter, it only contains lowercase letters afterward.
            //o Each of the two words should be at least two letters long.
            //o The two words are separated by a single space.
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(names, pattern);

            foreach (var item in matchCollection)
            {
                Console.Write(item + " ");
            }

        }
    }
}

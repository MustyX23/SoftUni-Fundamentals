using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();

            string input;

            while ((input = Console.ReadLine())!= "end of the race")
            {
                string namePattern = @"(?<name>[A-Za-z]+)";
                MatchCollection nameCollection = Regex.Matches(input, namePattern);               

                string numbersPattern = @"(?<numbers>\d)";
                MatchCollection numberCollection = Regex.Matches(input, numbersPattern);
            }
        }
    }
}

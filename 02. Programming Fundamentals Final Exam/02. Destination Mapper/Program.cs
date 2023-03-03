using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> places = new List<string>();
            
            string pattern = @"(\=|\/)([A-Z][A-Za-z]{2,})\1";

            int travelPoints = 0;

            MatchCollection matchCollection = Regex.Matches(input, pattern);

            foreach (Match rawPlace in matchCollection)
            {
                places.Add(rawPlace.ToString().Trim('=', '/'));
            }

            foreach (string place in places)
            {
                travelPoints += place.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read the number of looping times
            int n = int.Parse(Console.ReadLine());

            //Create a Boss pattern
            string pattern = @"([|])(?<name>[A-Z]{4,})\1:(#)(?<title>[A-Z][a-z]+ [A-Z]*[a-z]+)\2";

            Regex regex = new Regex(pattern);

            //Add values into the matches by the input bellow
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                // Match the input against the regular expression pattern
                Match bossMatch = regex.Match(input);

                if (bossMatch.Success)
                {
                    // Extract the boss name and title from the matched groups
                    string boss = bossMatch.Groups["name"].ToString();
                    string bossTite = bossMatch.Groups["title"].ToString();

                    // Print the boss information
                    Console.WriteLine($"{boss}, The {bossTite}");
                    Console.WriteLine($">> Strength: {boss.Length}");
                    Console.WriteLine($">> Armor: {bossTite.Length}");

                }
                else
                {
                    // If the input does not match the pattern, print an error message
                    Console.WriteLine("Access denied!");
                }
            }


        }
    }
}

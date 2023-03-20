using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\||\#)(?<food>[A-Za-z\s]+)\1(?<date>(\d{2}\/)(\d{2}\/)(\d{2}))\1(?<calories>\d+)\1";

            MatchCollection matches = Regex.Matches(text, pattern);

            int neededCalories = 2000;
            int totalCalories = 0;
            int days = 0;

            foreach (Match calorie in matches)
            {                
                int calories = int.Parse(calorie.Groups["calories"].Value);
                totalCalories += calories;
            }

            days = totalCalories / neededCalories;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match item in matches)
            {
                string product = item.Groups["food"].Value;
                string date = item.Groups["date"].Value;
                int nutrition = int.Parse(item.Groups["calories"].Value);

                Console.WriteLine($"Item: {product}, Best before: {date}, Nutrition: {nutrition}");
            }
        }
    }
}

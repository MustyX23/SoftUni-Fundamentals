using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\/|-|.)(?<month>\w{3})\1(?<year>\d{4})\b";

            string input = Console.ReadLine();


            MatchCollection matchCollection = Regex.Matches(input, pattern);

            foreach (Match item in matchCollection)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double price = 0;
            int quantity = 0;
            double totalPrice = 0;

            bool isMatched = false;

            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d*\.?\d*)!(?<quantity>\d*)";
            List<string> nameList= new List<string>();
            
            while (input != "Purchase")
            {
                //">>{furniture name}<<{price}!{quantity}"

                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (match.Success)
                {
                    nameList.Add(match.Groups["furniture"].Value);
                    price = double.Parse(match.Groups["price"].Value);
                    quantity = int.Parse(match.Groups["quantity"].Value);

                    totalPrice += price * quantity;
                    isMatched = true;
                }

                input = Console.ReadLine();
            }

            if (isMatched == true)
            {
                Console.WriteLine("Bought furniture:");
                Console.WriteLine(String.Join(Environment.NewLine, nameList));
                Console.WriteLine($"Total money spend: {totalPrice}");
            }

        }
    }
}

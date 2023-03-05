using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> map = new Dictionary<string, List<double>>();
            string input;

            double totalPrice = 0;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[]commandArgs = input.Split(" ");

                string name = commandArgs[0];
                double price = double.Parse(commandArgs[1]);
                int quantity = int.Parse(commandArgs[2]);

                if (!map.ContainsKey(name))
                {
                    List<double>priceQuantity = new List<double>();
                    priceQuantity.Add(price);
                    priceQuantity.Add(quantity);
                    map.Add(name, priceQuantity);
                }
                else
                {
                    map[name][0] = price;
                    map[name][1] += quantity;                   
                }
               
            }

            foreach (var item in map)
            {
                totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}

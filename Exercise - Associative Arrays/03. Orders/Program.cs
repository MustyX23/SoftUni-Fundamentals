using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> map = new Dictionary<string, List<double>>();

            string input;

            while ((input = Console.ReadLine())!= "buy")
            {
                string[] products = input.Split(' ');

                string name = products[0];
                double price = double.Parse(products[1]);
                double quantity = double.Parse(products[2]);

                if (!map.ContainsKey(name))
                {
                    map.Add(name, new List<double>() {price, quantity});
                }
                else
                {
                    map[name][0] = price;
                    map[name][1] += quantity;
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}

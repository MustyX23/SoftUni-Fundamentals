using System;
namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            decimal sumCoins = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    sumCoins = sumCoins + decimal.Parse(input);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
            }

            string product = null;
            decimal price = 0;

            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts")
                {
                    price = 2.0m;
                }
                else if (product == "Water")
                {
                    price = 0.7m;
                }
                else if (product == "Crisps")
                {
                    price = 1.5m;
                }
                else if (product == "Soda")
                {
                    price = 0.8m;
                }
                else if (product == "Coke")
                {
                    price = 1.0m;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if (sumCoins >= price && sumCoins > 0 && price > 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sumCoins -= price;
                    price = 0;
                }
                else if (price > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    price = 0;
                }
            }
            Console.WriteLine($"Change: {sumCoins:F2}");

        }
    }
}

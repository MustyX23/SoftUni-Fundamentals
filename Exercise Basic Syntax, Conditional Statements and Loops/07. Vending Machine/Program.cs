using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            string input = Console.ReadLine();

            while (input != "Start")
            {
                double coin;
                if (double.TryParse(input, out coin) && IsValidCoin(coin))
                {
                    balance += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }

                input = Console.ReadLine();
            }

            string[] products = { "Nuts", "Water", "Crisps", "Soda", "Coke" };
            double[] prices = { 2.0, 0.7, 1.5, 0.8, 1.0 };

            input = Console.ReadLine();

            while (input != "End")
            {
                int productIndex = Array.IndexOf(products, input);
                if (productIndex == -1)
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    double productPrice = prices[productIndex];
                    if (balance >= productPrice)
                    {
                        balance -= productPrice;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {balance:F2}");
        }

        static bool IsValidCoin(double coin)
        {
            return coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2;
        }

    }
}


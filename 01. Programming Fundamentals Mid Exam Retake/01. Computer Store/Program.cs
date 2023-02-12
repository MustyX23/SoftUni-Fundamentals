using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumPartsPrices = 0;
            double taxPrices = 0;

            while (input != "regular" && input != "special")
            {
                double partsPrices = double.Parse(input);
                if (partsPrices > 0)
                {
                    sumPartsPrices += partsPrices;
                    taxPrices = sumPartsPrices * 0.2;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
                input = Console.ReadLine();
            }
            double totalPrice = sumPartsPrices + taxPrices;
            double discount = totalPrice * 0.10;
            if (input == "special")
            {
                totalPrice -= discount;
            }
            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sumPartsPrices:f2}$");
            Console.WriteLine($"Taxes: {taxPrices:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
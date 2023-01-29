using System;
using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static double GetPrice(int people, string type, string day)
        {
            double[] prices = { 8.45, 10.90, 15.00, 9.80, 15.60, 20.00, 10.46, 16.00, 22.50 };
            int priceIndex = 0;

            if (type == "Business") priceIndex += 1;
            else if (type == "Regular") priceIndex += 2;
            if (day == "Saturday") priceIndex += 3;
            else if (day == "Sunday") priceIndex += 6;

            return prices[priceIndex] * people;
        }

        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price;

            if (type == "Students" && people >= 30)
            {
                price = 0.85 * GetPrice(people, type, day);
            }
            else if (type == "Business" && people >= 100)
            {
                price = GetPrice(people - 10, type, day);
            }
            else if (type == "Regular" && people >= 10 && people <= 20)
            {
                price = 0.95 * GetPrice(people, type, day);
            }
            else 
            {
                price = GetPrice(people, type, day);
            } 

            Console.WriteLine($"Total price: {price:f2}");

        }
        
    }
}

using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCalculation();
        }

        static void PrintCalculation()
        {
            string order = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (order == "coffee")
            {
                price += 1.50;
            }
            else if (order == "water")
            {
                price += 1.00;
            }
            else if (order == "coke")
            {
                price += 1.40;
            }
            else if (order == "snacks")
            {
                price += 2.00;
            }
            Console.WriteLine($"{price * quantity:f2}");
        }
    }
}

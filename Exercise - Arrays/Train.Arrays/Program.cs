using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Arrays_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double initialBalance = balance;
            string gameName = "";
            double price = 0;
            double moneySpent = 0;

            while ((gameName = Console.ReadLine()) != "Game Time")
            {                
                if (gameName == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (gameName == "CS: OG")
                {
                    price = 15.99;

                }
                else if (gameName == "Zplinter Zell")
                {
                    price = 19.99;

                }
                else if (gameName == "Honored 2")
                {
                    price = 59.99;

                }
                else if (gameName == "RoverWatch")
                {
                    price = 29.99;

                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    price = 39.99;

                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                if (price > balance) 
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (price != 0)
                {
                    balance -= price;
                    Console.WriteLine($"Bought {gameName}");
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                
            }

            Console.WriteLine($"Total spent: ${initialBalance - balance:f2}. Remaining: ${balance:f2}");

        }
    }
}
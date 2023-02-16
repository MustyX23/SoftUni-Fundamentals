using System;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            int health = 100;
            int bicoins = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] command = input[i].Split(" ");

                string commandName = command[0];
                int number = int.Parse(command[1]);

                if (commandName == "potion")
                {
                    int curentHealt = health;
                    health += number;
                    if (health > 100)
                    {
                        health = 100;
                        number = 100 - curentHealt;
                    }

                    Console.WriteLine($"You healed for {number} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (commandName == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bicoins += number;
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {commandName}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {commandName}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bicoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}

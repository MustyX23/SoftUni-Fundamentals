using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> pairs = new Dictionary<string, List<int>>();
            string input;

            while ((input = Console.ReadLine())!= "Sail")
            {
                string[]commandArgs = input.Split("||");

                string town = commandArgs[0];
                int population = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);

                if (!pairs.ContainsKey(town))
                {
                    pairs.Add(town, new List<int> {population, gold});
                }
                else
                {
                    pairs[town][0] += population;
                    pairs[town][1] += gold;
                }
            }

            string secondInput;

            while ((secondInput = Console.ReadLine()) != "End")
            {
                string[] commandArgs = secondInput.Split("=>");

                string action = commandArgs[0];
                if (action == "Plunder")
                {
                    string town = commandArgs[1];
                    int people = int.Parse(commandArgs[2]);
                    int gold = int.Parse(commandArgs[3]);

                    pairs[town][0] -= people;
                    pairs[town][1] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (pairs[town][0] <= 0 || pairs[town][1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        pairs.Remove(town);
                    }
                }
                else if (action == "Prosper")
                {
                    string town = commandArgs[1];
                    int gold = int.Parse(commandArgs[2]);

                    if (gold > 0)
                    {
                        pairs[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {pairs[town][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                }
            }

            Console.WriteLine($"Ahoy, Captain! There are {pairs.Count} wealthy settlements to go to:");

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
            }

        }
    }
}

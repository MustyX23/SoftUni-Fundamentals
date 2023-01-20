using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                string ore = input;

                int quantity = int.Parse(Console.ReadLine());

                if (!map.ContainsKey(ore))
                {
                    map.Add (ore, quantity);
                }
                else
                {
                    map[ore] += quantity;
                }
               
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

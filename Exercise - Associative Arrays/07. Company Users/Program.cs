using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" -> ");
                string companyName = commandArgs[0];
                string id = commandArgs[1];

                if (!map.ContainsKey(companyName))
                {
                    map.Add(companyName, new List<string>());
                                   
                }

                if (!map[companyName].Contains(id))
                {
                    map[companyName].Add(id);
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine(item.Key);
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}

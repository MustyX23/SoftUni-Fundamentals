using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Plant
    {
        string plantName;
        int rarity;
        List<double> rates = new List<double>();
        double averageValue = 0;
        public void addRate(double rate)
        {
            this.averageValue = 0;
            this.rates.Add(rate);
            for (int i = 0; i < this.rates.Count; i++)
            {
                this.averageValue += this.rates[i];
            }
            this.averageValue = this.averageValue / this.rates.Count;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> dict = new Dictionary<string, Plant>();
            for (int i = 0; i < n; i++)
            {
                string plant = Console.ReadLine();
                string[] plantParts = plant.Split("<->");
                if (dict.ContainsKey(plantParts[0]))
                {
                    dict[plantParts[0]].rarity = int.Parse(plantParts[1]);
                }
                else
                {
                    Plant p = new Plant();
                    p.plantName = plantParts[0];
                    p.rarity = int.Parse(plantParts[1]);
                    dict.Add(plantParts[0], p);
                }

            }
            string command = Console.ReadLine();
            while (!command.Contains("Exhibition"))
            {
                string[] values = command.Split(" ");
                if (values[0].Contains("Rate"))
                {
                    if (dict.ContainsKey(values[1]))
                    {
                        //dict[values[1]].rates.Add(double.Parse(values[3]));
                        dict[values[1]].addRate(double.Parse(values[3]));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (values[0].Contains("Update"))
                {
                    if (dict.ContainsKey(values[1]))
                    {
                        dict[values[1]].rarity = int.Parse(values[3]);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (values[0].Contains("Reset"))
                {
                    if (dict.ContainsKey(values[1]))
                    {
                        dict[values[1]].rates.Clear();
                        dict[values[1]].averageValue = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in dict.OrderByDescending(x => x.Value.rarity).ThenByDescending(x => x.Value.averageValue))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.rarity}; Rating: {item.Value.averageValue:f2}");
            }

        }
    }
}
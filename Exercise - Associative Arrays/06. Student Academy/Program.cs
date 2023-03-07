using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> map = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            List<double> averageGrade = new List<double>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!map.ContainsKey(name))
                {
                    map.Add(name, new List<double>());
                }
                map[name].Add(grade);
            }

            foreach (var item in map)
            {
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}

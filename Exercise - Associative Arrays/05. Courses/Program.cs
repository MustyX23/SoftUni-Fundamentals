using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> map = new Dictionary<string, Dictionary<string, int>>();
            string input;

            while ((input = Console.ReadLine())!= "end")
            {
                string[] commandArgs = input.Split(" : ");

                string courseName = commandArgs[0];
                string studentName = commandArgs[1];
                Dictionary<string, int> studentNameCount = new Dictionary<string, int>();

                if (!map.ContainsKey(courseName))
                {
                    map.Add(courseName, new Dictionary<string, int>());
                }

                if (!map[courseName].ContainsKey(studentName))
                {
                    map[courseName].Add(studentName, 0);
                }

                map[courseName][studentName]++;

            }

            foreach (var key in map)
            {
                Console.WriteLine($"{key.Key}: {key.Value.Count}");

                foreach (var value in key.Value)
                {
                    Console.WriteLine($"-- {value.Key}");
                }
            }
            

        }
    }
}

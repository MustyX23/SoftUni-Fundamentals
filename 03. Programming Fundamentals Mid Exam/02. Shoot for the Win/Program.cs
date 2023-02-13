using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                targets.RemoveAt(index);
                targets.Insert(index, -1);

                for (int i = 1; i < targets.Count - 1; i++)
                {
                    if (targets[i] > targets[index])
                    {
                        targets[i] -= targets[index];
                    }
                }
            }
        }
    }
}

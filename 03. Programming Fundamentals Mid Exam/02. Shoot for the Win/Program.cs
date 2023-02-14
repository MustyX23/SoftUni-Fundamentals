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
            //24 50 36 70
            string input;
            int count = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                
                if (index >= 0 && index < targets.Count)
                {
                    for (int i = 0; i < targets.Count; i++)
                    {                       
                        if (i!= index && targets[i] != -1)
                        {
                            if (targets[i] > targets[index])
                            {
                                targets[i] -= targets[index];
                            }
                            else
                            {
                                targets[i] += targets[index];
                            }
                        }                       
                    }

                    targets[index] = -1;
                    count++;
                }                                                 
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', targets)}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;

            while ((input= Console.ReadLine())!= "End")
            {
                string[] command = input.Split(' ');
                string action = command[0];

                if (action == "Shoot")
                {
                    //Shoot {index} {power}
                    int index = int.Parse(command[1]);
                    int power = int.Parse(command[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Add")
                {
                    //Add {index} {value}
                    int index = int.Parse(command[1]);
                    int value = int.Parse(command[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (action == "Strike")
                {
                    //Strike {index} {radius}
                    int index = int.Parse(command[1]);
                    int value = int.Parse(command[2]);

                    int radius = 1 + (value * 2);

                    int radiusStart = index - value;
                    int radiusEnd = index + value;

                    if (radiusStart >= 0 && radiusEnd < targets.Count)
                    {
                        targets.RemoveRange(radiusStart, radius);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }

                }
            }

            Console.WriteLine(String.Join('|',targets));
        }
    }
}

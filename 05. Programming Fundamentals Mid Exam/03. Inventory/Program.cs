using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                string[] command = input.Split(" ");

                string commandName = command[0];

                if (commandName == "Collect")
                {
                    string item = command[2];
                    if (items.Contains(item))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        items.Add(item);
                    }

                }

                else if (commandName == "Drop")
                {
                    string item = command[2];
                    if (!items.Contains(item))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        items.Remove(item);
                    }
                }

                else if (commandName == "Combine")
                {
                    string[] split = command[3].Split(":");
                    string oldItem = split[0];
                    string newItem = split[1];

                    if (!items.Contains(oldItem))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        int index = items.IndexOf(oldItem);
                        index++;
                        items.Insert(index, newItem);
                    }

                }

                else if (commandName == "Renew")
                {
                    string item = command[2];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }

                }
                input = Console.ReadLine();

            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}

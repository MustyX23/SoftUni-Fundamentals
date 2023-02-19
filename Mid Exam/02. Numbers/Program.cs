using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            // Process each command from the remaining input lines

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split(' ');
                string command = commandLine[0];
                
                if (command == "Add")
                {
                    int value = int.Parse(commandLine[1]);
                    list.Add(value);
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(commandLine[1]);
                    list.Remove(value);
                }
                else if (command == "Replace")
                {
                    int value = int.Parse(commandLine[1]);
                    int newValue = int.Parse(commandLine[2]);
                    int index = list.IndexOf(value);
                    list[index] = newValue;
                }
                else if (command == "Collapse")
                {
                    int value = int.Parse(commandLine[1]);
                    list.RemoveAll(x => x < value);
                }
                else if (command == "Finish")
                {
                    break;
                }
            }

            // Print the final list
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

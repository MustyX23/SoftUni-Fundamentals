using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestsList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(' ');
                string name = tokens[0];
                if (tokens.Length == 3)
                {
                    if (guestsList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestsList.Add(name);
                }
                else if (tokens.Length == 4)
                {
                    if (!guestsList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guestsList.Remove(name);
                }
            }
            PrintGuestNames(guestsList);
        }
        
        static void PrintGuestNames(List<string> allGuestNames)
        {
            for (int i = 0; i < allGuestNames.Count; i++)
            {
                Console.WriteLine(allGuestNames[i]);
            }
        }
    }
}

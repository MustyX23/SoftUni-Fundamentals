using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string command = input[0];

                if (command == "register")
                {
                    string username = input[1];
                    string licensePlateNumber = input[2];

                    if (!map.ContainsKey(username))
                    {
                        map.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    string username = input[1];

                    if (!map.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        map.Remove(username);
                    }
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}

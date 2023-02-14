using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Parse the input
        List<int> list = new List<int>();
        string[] input = Console.ReadLine().Split(' ');
        foreach (string s in input)
        {
            int value;
            if (int.TryParse(s, out value))
            {
                list.Add(value);
            }
        }

        // Execute the commands
        string command = Console.ReadLine();
        while (command != "End")
        {
            string[] parts = command.Split(' ');
            if (parts[0] == "Strike")
            {
                int index, radius;
                if (int.TryParse(parts[1], out index) && int.TryParse(parts[2], out radius))
                {
                    // Validate the index and radius
                    if (index >= 0 && index < list.Count)
                    {
                        if (radius <= 0 || radius > list.Count / 2)
                        {
                            Console.WriteLine("Invalid radius!");
                        }
                        else
                        {
                            // Remove items within the radius
                            int start = Math.Max(0, index - radius);
                            int end = Math.Min(list.Count - 1, index + radius);
                            while (end >= start)
                            {
                                list.RemoveAt(end);
                                end--;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
            else
            {
                Console.WriteLine("Invalid command!");
            }
            command = Console.ReadLine();
        }

        // Print the final list
        Console.WriteLine(string.Join("|", list));
    }
}


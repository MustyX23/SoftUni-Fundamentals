using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] command = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Travel")
            {
                if (command[0] == "Add Stop")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= text.Length - 1)
                    {
                        text = text.Insert(int.Parse(command[1]), command[2]);
                    }

                    // outside if-validation
                    Console.WriteLine(text);
                }
                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && endIndex >= 0 && startIndex <= text.Length - 1 && endIndex <= text.Length - 1)
                    {
                        text = text.Remove(startIndex, endIndex + 1 - startIndex);
                    }

                    // outside if-validation
                    Console.WriteLine(text);
                }
                else if (command[0] == "Switch")
                {
                    if (text.Contains(command[1]))
                    {
                        text = text.Replace(command[1], command[2]);
                    }

                    // outside if-validation
                    Console.WriteLine(text);
                }

                command = Console.ReadLine().Split(":");
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
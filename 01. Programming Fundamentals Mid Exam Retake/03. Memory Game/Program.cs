using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            int numberOfMoves = 0;

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                numberOfMoves++;

                string[] indexes = command.Split();
                int firstIndex = int.Parse(indexes[0]);
                int secondIndex = int.Parse(indexes[1]);



                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < input.Count && secondIndex < input.Count && firstIndex != secondIndex)
                {
                    if (input[firstIndex] == input[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {input[firstIndex]}!");

                        if (firstIndex > secondIndex)
                        {
                            input.RemoveAt(firstIndex);
                            input.RemoveAt(secondIndex);
                        }
                        else
                        {
                            input.RemoveAt(secondIndex);
                            input.RemoveAt(firstIndex);
                        }

                        if (input.Count == 0)
                        {
                            Console.WriteLine($"You have won in {numberOfMoves} turns!");
                            return;
                        }
                    }
                    else if (input[firstIndex] != input[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    input.Insert(input.Count / 2, $"-{numberOfMoves}a");
                    input.Insert(input.Count / 2, $"-{numberOfMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
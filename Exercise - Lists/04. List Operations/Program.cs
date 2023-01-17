using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(' ');
                string action = tokens[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);

                    if (indexToInsert < 0 || indexToInsert >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(indexToInsert, numberToInsert);
                }
                else if (action == "Remove")
                {
                    int removeIndex = int.Parse(tokens[1]);

                    if (IsIndexInvalid(numbers, removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(removeIndex);
                }
                else if (action == "Shift")
                {
                    string direction = tokens[1];
                    int count = int.Parse(tokens[2]);

                    if (direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }

                
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
        

        static void ShiftLeft(List<int>numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int i = 0; i < realPerformedCount; i++)
            {
                int firstElement = numbers[0];

                numbers.Remove(firstElement);
                numbers.Add(firstElement);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int i = 0; i < realPerformedCount; i++)
            {
                int lastElement = numbers[numbers.Count - 1];

                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastElement);
            }
        }

        static bool IsIndexInvalid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;
    }
}

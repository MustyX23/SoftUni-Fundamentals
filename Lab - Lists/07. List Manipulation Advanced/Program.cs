using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            bool hasChanged = false;
            while (command != "end")
            {
                string[] token = command.Split(' ');
                string action = token[0];

                if (action == "Add")
                {
                    hasChanged = true;
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action == "Remove")
                {
                    hasChanged = true;
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action == "RemoveAt")
                {
                    hasChanged = true;
                    int numberToRemoveAt = int.Parse(token[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                }
                else if (action == "Insert")
                {
                    hasChanged = true;
                    int numberToInsert = int.Parse(token[2]);
                    int indexToInsert = int.Parse(token[1]);
                    numbers.Insert(numberToInsert, indexToInsert);
                }
                else if (action == "Contains")
                {
                    int numberToContain = int.Parse(token[1]);

                    if (numbers.Contains(numberToContain))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(String.Join(' ', evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(String.Join(' ', oddNumbers));
                }
                else if (action == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (action == "Filter")
                {
                    string conditionOfFilter = token[1];
                    int filteredNumber = int.Parse(token[2]);
                    Console.WriteLine(string.Join(' ', GetFilteredNumbers(numbers, conditionOfFilter, filteredNumber)));
                }

                command = Console.ReadLine();


            }
            if (hasChanged)
            {
                Console.WriteLine(String.Join(' ', numbers));
            }


        }

        static List<int> GetFilteredNumbers(List<int> allNumbers,
        string condition, int numberToCompare)
        {
            if (condition == "<")
            {
                List<int> result = allNumbers.FindAll(x => x < numberToCompare);
                return result;
            }
            else if (condition == ">")
            {
                List<int> result = allNumbers.FindAll(x => x > numberToCompare);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = allNumbers.FindAll(x => x >= numberToCompare);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = allNumbers.FindAll(x => x <= numberToCompare);
                return result;
            }
            else
            {
                return allNumbers;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                if (command == "Add")
                {
                    int addingNumber = int.Parse(tokens[1]);
                    list.Add(addingNumber);
                }
                else if (command == "Remove")
                {
                    int removingNumber = int.Parse(tokens[1]);
                    list.Remove(removingNumber);
                }
                else if (command == "RemoveAt")
                {
                    int removingNumberAt = int.Parse(tokens[1]);
                    list.RemoveAt(removingNumberAt);
                }
                else if (command == "Insert")
                {
                    int numberInsert = int.Parse(tokens[1]);
                    int indexInsert = int.Parse(tokens[2]);

                    list.Insert(indexInsert, numberInsert);
                }
            }

            Console.WriteLine(String.Join(' ', list));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[]tokens = command.Split(' ');
                string action = tokens[0];

                if (action == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    numbers = RemoveElements(numbers, element);
                }
                else if (action == "Insert")
                {
                    int element = int.Parse(tokens[2]);
                    int position = int.Parse(tokens[1]);
                    numbers.Insert(element, position);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', numbers));
        }

        static List<int> RemoveElements(List<int> numbers, int element)
        {
            return numbers.Where(x => x != element).ToList();
        }
    }
}

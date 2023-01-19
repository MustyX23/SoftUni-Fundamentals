using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Pascal_Triangle
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
                

                if (command == "swap")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    Swap(list, firstIndex, secondIndex);
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    Multiply(list, firstIndex, secondIndex);
                }
                else if (command == "decrease")
                {
                    Decrease(list);
                }
            }

            Console.WriteLine(String.Join(", ", list));
        }

        static List<int> Swap(List<int> list, int firstIndex, int secondIndex)
        {
            (list[firstIndex], list[secondIndex]) = (list[secondIndex], list[firstIndex]);
            return list;
            //int element = list[firstIndex];
            //list[firstIndex] = list[secondIndex];
            //list[secondIndex] = element;
            //return list;
        }
        static List<int> Multiply(List<int> list, int firstIndex, int secondIndex)
        {
            list[firstIndex] = list[firstIndex] * list[secondIndex];

            return list;            
        }
        static List<int> Decrease(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i]--;
            }
            return list;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("!").ToList();

            string input;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split(' ');
                string action = command[0];

                if (action == "Urgent")
                {
                    string item = command[1];
                    Urgent(list, item);
                }
                else if (action == "Unnecessary")
                {
                    string item = command[1];
                    Unnecessary(list, item);                   
                }
                else if (action == "Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];
                    Correct(list, oldItem, newItem);
                }
                else if (action == "Rearrange")
                {
                    string item = command[1];
                    Rearrange(list, item);
                }
            }

            Print(list);

        }
        static void Urgent(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                return;
            }
            else
            {
                list.Insert(0, item);
            }
        }
        static void Unnecessary(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
            }
            else
            {
                return;
            }
        }
        static void Correct(List<string> list, string oldItem, string newItem)
        {
            if (list.Contains(oldItem))
            {
                int index = list.FindIndex(i => i == oldItem);
                if (index != -1)
                {
                    list.RemoveAt(index);
                    list.Insert(index, newItem);
                }
                else
                {
                    return;
                }
            }
        }
        static void Rearrange(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                list.Add(item);
            }
            else
            {
                return;
            }
        }
        static void Print(List<string> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }

    }
}

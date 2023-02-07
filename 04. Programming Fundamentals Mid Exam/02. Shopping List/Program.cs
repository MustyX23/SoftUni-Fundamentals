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
                    if (list.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        list.Insert(0, item);
                    }
                }
                else if (action == "Unnecessary")
                {
                    string item = command[1];
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];

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
                            continue;
                        }
                    }                    
                }
                else if (action == "Rearrange")
                {
                    string item = command[1];
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                        list.Add(item);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", list));

        }
    }
}

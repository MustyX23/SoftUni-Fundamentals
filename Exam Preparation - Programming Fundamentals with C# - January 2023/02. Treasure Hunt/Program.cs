using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that manages the state of the treasure chest along the way. On the first line, you will receive the initial loot of the treasure chest, which is a string of items separated by a "|".
            //"{loot1}|{loot2}|{loot3} … {lootn}"

            List<string> loot = Console.ReadLine().Split('|').ToList();
            
            //The following lines represent commands until "Yohoho!" which ends the treasure hunt:

            string input;

            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] command = input.Split(' ');
                string action = command[0];

                if (action == "Loot")
                {
                    //Pick up treasure loot along the way. Insert the items at the beginning of the chest.
                    //Loot {item1} {item2}…{itemn}
                    for (int i = 1; i < command.Length; i++)
                    {
                        string item = command[i];
                        if (!loot.Contains(item))
                        {
                            loot.Insert(0, item);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (action == "Drop")
                {
                    //Drop {index}
                    int index = int.Parse(command[1]);
                    //If the index is invalid, skip the command.
                    if (index < 0 || index >= loot.Count)
                    {
                        continue;
                    }
                    //Remove the loot at the given position and add it at the end of the treasure chest.
                    else
                    {
                        int indexOfLoot = loot.IndexOf(loot[index]);
                        loot.Add(loot[index]);
                        loot.RemoveAt(indexOfLoot);
                    }
                }
                else if (action == "Steal")
                {
                    //Steal {count}
                    //Someone steals the last count loot items.
                    List<string> stollenItems = new List<string>();

                    int count = int.Parse(command[1]);
                    //If there are fewer items than the given count, remove as much as there are.
                    if (loot.Count < count)
                    {
                        count = loot.Count;
                    }
                    //Remove the last count items from the treasure chest.
                    for (int i = 0; i < count; i++)
                    {
                        stollenItems.Add(loot[loot.Count - 1]);
                        loot.RemoveAt(loot.Count - 1);
                    }
                    stollenItems.Reverse();
                    Console.WriteLine(String.Join(", ", stollenItems));                                                        
                }
            }

           
            if (loot.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double averageTreasureGain = (double)loot.Sum(x => x.Length) / (double)loot.Count;
                Console.WriteLine($"Average treasure gain: {averageTreasureGain:f2} pirate credits.");
            }

        }
    }
}


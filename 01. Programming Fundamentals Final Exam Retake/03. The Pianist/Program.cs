using System;
using System.Collections;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var map = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                //"{piece}|{composer}|{key}"
                string[]commands = Console.ReadLine().Split('|');

                string piece = commands[0];
                string composer = commands[1];
                string key = commands[2];

                map.Add(piece, new List<string> {composer, key});
            }

            string input;

            while ((input = Console.ReadLine())!= "Stop")
            {
                string[]commands = input.Split('|');                
                string action = commands[0];

                if (action == "Add")
                {
                    //"Add|{piece}|{composer}|{key}"
                    string piece = commands[1];
                    string composer = commands[2];
                    string key = commands[3];

                    if (!map.ContainsKey(piece))
                    {
                        //"{piece} by {composer} in {key} added to the collection!"
                        map.Add(piece, new List<string> {composer, key});
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    //"Remove|{piece}"
                    string piece = commands[1];
                    if (!map.ContainsKey(piece))
                    {
                        //Print:
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        //If the piece is in the collection, remove it and print:
                        map.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                }
                else if (action == "ChangeKey")
                {
                    //"ChangeKey|{piece}|{new key}"
                    string piece = commands[1];
                    string newKey = commands[2];

                    if (map.ContainsKey(piece))
                    {
                        //If the piece is in the collection, change its key with the given one and print:                       
                        map[piece][1] = newKey;
                        //"Changed the key of {piece} to {new key}!"
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        //Otherwise, print:
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }

        }
    }
}

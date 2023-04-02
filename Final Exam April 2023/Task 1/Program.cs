using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commandStringArr = Console.ReadLine().Split();

            while (commandStringArr[0] != "Abracadabra")
            {
                string command = commandStringArr[0];

                if (command == "Abjuration")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (command == "Necromancy")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (command == "Illusion")
                {
                    int index = int.Parse(commandStringArr[1]);
                    string replacementChar = commandStringArr[2];

                    if (index < 0 || index >= input.Length)
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                    else if (index >= 0 && index < input.Length)
                    {
                        input = input.Remove(index, 1);
                        input = input.Insert(index, replacementChar);
                        Console.WriteLine("Done!");
                    }
                }
                else if (command == "Divination")
                {
                    string firstSubstring = commandStringArr[1];
                    string secondSubstring = commandStringArr[2];

                    if (input.Contains(firstSubstring))
                    {
                        while (input.Contains(firstSubstring))
                        {
                            input = input.Replace(firstSubstring, secondSubstring);
                        }
                        Console.WriteLine(input);
                    }
                }
                else if (command == "Alteration")
                {
                    string stringToRemove = commandStringArr[1];

                    if (input.Contains(stringToRemove))
                    {
                        input = input.Remove(input.IndexOf(stringToRemove), stringToRemove.Length);
                        Console.WriteLine(input);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }

                commandStringArr = Console.ReadLine().Split();
            }
        }
    }
}

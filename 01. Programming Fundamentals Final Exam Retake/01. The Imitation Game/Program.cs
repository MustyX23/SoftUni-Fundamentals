using System;
using System.Linq;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string commands;

            while ((commands = Console.ReadLine()) != "Decode")
            {
                string[]commandArgs = commands.Split('|');
                string action = commandArgs[0];

                if (action == "Move")
                {
                    int n = int.Parse(commandArgs[1]);

                    string substring = message.Substring(0, n);
                    message = message.Remove(0, n);
                    message += substring;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];

                    message = message.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];
                    message = message.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}

using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string commandArgs;

            while ((commandArgs = Console.ReadLine())!= "Generate")
            {
                string[] tokens = commandArgs.Split(">>>");

                string action = tokens[0];
                if (action == "Contains")
                {
                    string substring = tokens[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string upOrLow = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                    int length = endIndex - startIndex;

                    if (upOrLow == "Upper")
                    {                      
                        string substring = input.Substring(startIndex, length).ToUpper();

                        input = input.Remove(startIndex, length).Insert(startIndex, substring);
                    }
                    else if (upOrLow == "Lower")
                    {
                        string substring = input.Substring(startIndex, length).ToLower();

                        input = input.Remove(startIndex, length).Insert(startIndex, substring);
                    }

                    Console.WriteLine(input);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int length = endIndex - startIndex;

                    input = input.Remove(startIndex, length);

                    Console.WriteLine(input);
                }                
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}

using System;

namespace _01._Decrypting_Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Finish")
            {
                string[] decryptingCommand = command.Split(" ");

                if (decryptingCommand[0] == "Replace")
                {
                    char currentChar = decryptingCommand[1][0];
                    char newChar = decryptingCommand[2][0];
                    s = s.Replace(currentChar, newChar);
                    Console.WriteLine(s);
                }
                else if (decryptingCommand[0] == "Cut")
                {
                    int startIndex = int.Parse(decryptingCommand[1]);
                    int endIndex = int.Parse(decryptingCommand[2]);
                    if (0 <= startIndex && startIndex < s.Length && 0 <= endIndex && endIndex < s.Length)
                    {
                        s = s.Substring(0, startIndex) + s.Substring(endIndex + 1);
                        Console.WriteLine(s);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (decryptingCommand[0] == "Make")
                {
                    if (decryptingCommand[1] == "Upper")
                    {
                        s = s.ToUpper();
                    }
                    else
                    {
                        s = s.ToLower();
                    }
                    Console.WriteLine(s);
                }
                else if (decryptingCommand[0] == "Check")
                {
                    string substring = decryptingCommand[1];
                    if (s.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                }
                else if (decryptingCommand[0] == "Sum")
                {
                    int startIndex = int.Parse(decryptingCommand[1]);
                    int endIndex = int.Parse(decryptingCommand[2]);
                    if (0 <= startIndex && startIndex < s.Length && 0 <= endIndex && endIndex < s.Length)
                    {
                        string substring = s.Substring(startIndex, endIndex - startIndex + 1);
                        int asciiSum = 0;
                        foreach (char c in substring)
                        {
                            asciiSum += (int)c;
                        }
                        Console.WriteLine(asciiSum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}               



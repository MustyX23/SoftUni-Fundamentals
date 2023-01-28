using System;
using System.Text.RegularExpressions;

namespace _02._Message_Decrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\$|\%)([A-Z][a-z]{2,})\1\:\s(\[(\d+)\])\|(\[(\d+)\])\|(\[(\d+)\])\|$";
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string message = Console.ReadLine();
                Match validMessage = Regex.Match(message, pattern);
                if (validMessage.Success)
                {
                    string tag = validMessage.Groups[2].Value;
                    char firstSymbol = (char)int.Parse(validMessage.Groups[4].Value);
                    char secondSymbol = (char)int.Parse(validMessage.Groups[6].Value);
                    char thirdSymbol = (char)int.Parse(validMessage.Groups[8].Value);
                    Console.WriteLine($"{tag}: {firstSymbol + secondSymbol + thirdSymbol}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}

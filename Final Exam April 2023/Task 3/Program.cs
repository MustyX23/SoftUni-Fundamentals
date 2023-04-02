using System;
using System.Collections.Generic;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a dictionary to store the words and their definitions
            Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();

            //Read the input for the words and their definitions
            string[] inputWords = Console.ReadLine().Split(" | ");
            foreach (string inputWord in inputWords)
            {
                string[] wordAndDefinition = inputWord.Split(": ");
                string word = wordAndDefinition[0];
                string definition = wordAndDefinition[1];

                //Check if the word already exists in the dictionary
                if (notebook.ContainsKey(word))
                {
                    // Add the definition to the existing list
                    notebook[word].Add(definition);
                }
                else
                {
                    // Create a new list with the definition
                    List<string> definitions = new List<string>();
                    definitions.Add(definition);
                    // Add the new word and list of definitions to the dictionary
                    notebook.Add(word, definitions);
                }
            }

            // Read the input for the words to test
            string[] wordsToTest = Console.ReadLine().Split(" | ");

            // Read the command
            string command = Console.ReadLine();

            // Execute the command
            if (command == "Test")
            {
                foreach (string word in wordsToTest)
                {
                    if (notebook.ContainsKey(word))
                    {
                        Console.WriteLine(word + ":");
                        foreach (string definition in notebook[word])
                        {
                            Console.WriteLine("-" + definition);
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                Console.WriteLine(string.Join(" ", notebook.Keys));
            }
        }
    }
}

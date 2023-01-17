using System;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the initial array of strings
            string[] array = Console.ReadLine().Split();

            // Continue reading commands until we reach the "3:1" command
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "3:1")
                {
                    break;
                }

                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    // Make sure the start and end indexes are within the bounds of the array
                    startIndex = Math.Max(0, startIndex);
                    endIndex = Math.Min(array.Length - 1, endIndex);

                    // Concatenate the strings in the specified range
                    string mergedString = string.Join("", array.Skip(startIndex).Take(endIndex - startIndex + 1));

                    // Replace the original strings with the merged string
                    array = array.Take(startIndex).Concat(new string[] { mergedString }).Concat(array.Skip(endIndex + 1)).ToArray();
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    // Divide the string at the specified index into equal-length substrings
                    string[] divided = divideString(array[index], partitions);

                    // Replace the original string with the divided substrings
                    array = array.Take(index).Concat(divided).Concat(array.Skip(index + 1)).ToArray();
                }
            }

            // Print the resulting array
            Console.WriteLine(string.Join(" ", array));
        }

        static string[] divideString(string s, int partitions)
        {
            // Calculate the length of each partition
            int partitionLength = s.Length / partitions;

            // Divide the string into equal-length partitions
            string[] divided = new string[partitions];
            for (int i = 0; i < partitions; i++)
            {
                divided[i] = s.Substring(i * partitionLength, partitionLength);
            }

            // If the string could not be exactly divided into the given number of partitions,
            // make the last partition longer to compensate
            if (s.Length % partitions != 0)
            {
                divided[partitions - 1] += s.Substring(partitions * partitionLength);
            }

            return divided;
        }
    }
}

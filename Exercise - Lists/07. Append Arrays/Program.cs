using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            List<int> result = new List<int>();

            //BackRow iteration 
            for (int i = input.Length - 1; i >= 0; i--)
            {
                //adds all numbers backwards in the "result List".
                List<int> trimmedNums = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                result.AddRange(trimmedNums);
            }
            //Prints the result List
            Console.WriteLine(String.Join(' ',result));
            

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (!map.ContainsKey(wordInLowerCase))
                {
                    map.Add(wordInLowerCase, 1);
                }
                else
                {
                    map[wordInLowerCase]++;
                }
            }
            foreach (var item in map)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
            
        }
    }   
}

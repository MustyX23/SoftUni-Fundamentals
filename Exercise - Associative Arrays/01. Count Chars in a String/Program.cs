using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,int>map=new Dictionary<char,int>();

            string text = Console.ReadLine();

            foreach (var ch in text)
            {
                if (!map.ContainsKey(ch))
                {
                    map.Add(ch, 1);
                }
                else
                {
                    map[ch]++;
                }
            }

            foreach (KeyValuePair <char, int> ch in map.Where(x => x.Key != ' '))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}

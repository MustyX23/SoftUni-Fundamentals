using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(key))
            {
                int start = text.IndexOf(key);
                text = text.Remove(start, key.Length);
            }
        }
    }
}

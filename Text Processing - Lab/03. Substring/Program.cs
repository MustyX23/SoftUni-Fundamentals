using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(key);
            while (index != -1)
            {
                text = text.Remove(text.IndexOf(key), key.Length);
                index = text.IndexOf(key);
            }

            Console.WriteLine(text);
        }
    }
}

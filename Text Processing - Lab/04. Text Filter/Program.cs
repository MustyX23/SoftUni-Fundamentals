using System;
using System.Text;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linux, Windows
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            char asteriks = '*';

            foreach (var item in bannedWords)
            {
                text = text.Replace(item, new string(asteriks, item.Length));
            }

            Console.WriteLine(text);
        }
    }
}

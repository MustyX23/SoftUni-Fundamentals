using System;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();

            foreach (var item in strings)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result.Append(item);
                }
            }

            Console.WriteLine(result);
        }
    }
}

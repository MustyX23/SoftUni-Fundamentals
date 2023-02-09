using System;
using System.Text;
namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //someText -> 012 34 567 - Length = 8
            MiddleChar(input);
        }
        static void MiddleChar(string input)
        {
            int index = input.Length / 2;
            

            if (input.Length % 2 == 0)
            {
                char firstIndex = input[index - 1];
                char secondIndex = input[index];
                string result = firstIndex.ToString() + secondIndex.ToString();

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(input[index]);
            }
            
        }
    }
}

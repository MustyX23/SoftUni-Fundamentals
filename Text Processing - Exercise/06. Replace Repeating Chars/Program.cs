using System;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //abbbcdd

            int index = 1;
            while (index != input.Length)
            {
                if (input[index] == input[index - 1])
                {
                    input = input.Remove(index, 1);
                    index--;
                }
                index++;
            }

            Console.WriteLine(input);

        }
    }
}

using System;
using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string context = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeater(context, count));
        }
        static string StringRepeater(string context, int count)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(context);
            }
            return stringBuilder.ToString();
        }
    }
}

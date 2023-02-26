using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sadomazohizm 100/100

            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder result = new StringBuilder();
            int product = 0;
            int reminder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int firstInt = int.Parse(firstNumber[i].ToString());

                product = firstInt * secondNumber + reminder;

                if (product < 10)
                {
                    result.Append(product);
                    reminder = 0;
                }
                else
                {
                    result.Append(product % 10);
                    reminder = product / 10;

                    if (i == 0)
                    {
                        result.Append(reminder);
                    }
                }
            }

            Console.WriteLine(string.Join("", result.ToString().TrimEnd('0').ToCharArray().Reverse()));
        }
    }
}

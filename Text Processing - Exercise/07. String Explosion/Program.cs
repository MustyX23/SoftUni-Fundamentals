using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //abv>1>1>2>2asdasd -> abv>>1>2>2asdasd -> abv>>>2>2asdasd -> abv>>>>2asdasd
            //Output: abv>>>>dasd

            StringBuilder output = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '>')
                {
                    output.Append(currentChar);
                    int currentBombPower = ConvertBombPower(input[i + 1]);
                    bombPower += currentBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        output.Append(currentChar);
                    }
                }
            }

            Console.WriteLine(output);

        }
        
        static int ConvertBombPower(char ch)
        {
            return (int)ch - 48;
        }
    }
}

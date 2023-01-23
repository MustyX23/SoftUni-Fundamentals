using System;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reversing a String using a char[] and reversing with Array class
            string firstInput = "Hello";

            char[]firstString = firstInput.ToCharArray();

            Array.Reverse(firstString);

            Console.WriteLine($"{firstInput} -> {new string (firstString)}");

            Console.WriteLine("--------------");

            string secondInput = "Hello";
            string reversed = string.Empty;

            for (int i = secondInput.Length - 1; i >= 0; i--)
            {
                reversed += secondInput[i];
            }

            Console.WriteLine($"{secondInput} -> {reversed}");
        }
    }
}

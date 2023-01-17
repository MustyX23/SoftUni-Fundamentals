using System;
using System.Collections.Generic;


class Program
{
    static int GetFactoriel(int n)
    {
        if (n <= 1) return 1;
        return n * GetFactoriel(n - 1);
    }

    static List<int> GetDigitsList(int number)
    {
        List<int> digits = new List<int>();
        while (number != 0)
        {
            digits.Add(number % 10);
            number /= 10;
        }
        return digits;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<int> digits = GetDigitsList(number);
        int sumFactoriels = 0;
        foreach (int digit in digits)
            sumFactoriels += GetFactoriel(digit);

        if (sumFactoriels == number) Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}


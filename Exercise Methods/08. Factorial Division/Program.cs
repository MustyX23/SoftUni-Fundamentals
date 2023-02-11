using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(FactorielsDevicion(firstNum, secondNum));                       
        }
        static double FactorielsDevicion(int firstNum, int secondNum)
        {
            double firstFactoriel = 1;
            double secondFactoriel = 1;

            for (int i = firstNum; i > 0; i--)
            {
                firstFactoriel *= i;
            }
            for (int i = secondNum; i > 0; i--)
            {
                secondFactoriel *= i;
            }

            double result = firstFactoriel - secondFactoriel;
            return result;
        }
    }
}

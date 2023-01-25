using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if (command == "multiply")
            {
                Console.WriteLine(Multiply(firstNum, secondNum));
            }
            else if (command == "add")
            {
                Console.WriteLine(Add(firstNum, secondNum));
            }
            else if (command == "substract")
            {
                Console.WriteLine(Substract(firstNum, secondNum));
            }
            else if (command == "divide")
            {
                Console.WriteLine(Divide(firstNum, secondNum));
            }
        }

        static double Multiply(double firstNum, double secondNum)
        {
            double result = firstNum * secondNum;
            return result;
        }
        static double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        static double Substract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        static double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }

    }
}

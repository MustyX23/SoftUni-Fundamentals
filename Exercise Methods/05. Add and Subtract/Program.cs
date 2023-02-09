using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum);
            int result = (sum - thirdNum);

            Console.WriteLine(result);
        }
        static int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        static int Substract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
    }
}

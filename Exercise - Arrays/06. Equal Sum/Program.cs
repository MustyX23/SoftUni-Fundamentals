using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isEqual = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;


                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    break;  
                }
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            } 
            
        }
    }
}



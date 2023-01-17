using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // 1 7 6 2 19 23
            // 0 1 2 3 4 5

            int magicSum = int.Parse(Console.ReadLine());
            //8
            
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                //1 -> arr[0];
                //6 -> arr[2];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int secNum = arr[j];
                    //7 -> arr[1];
                    //2 -> arr[4];
                    if (currNum + secNum == magicSum)
                        //1 + 7 == 8
                        //6 + 2 == 8
                    {
                        Console.WriteLine($"{currNum} {secNum}");
                        //1 7
                        //6 2
                    }
                }
            }

        }
    }
}

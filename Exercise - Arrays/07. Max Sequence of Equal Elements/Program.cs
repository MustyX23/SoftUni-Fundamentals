using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // input
            //2 1 1 2 3 3 2 2 2 1
            //0 1 2 3 4 5 6 7 8 9

            // output
            //2 2 2

            int counter = 0;
            int length = 1;
            int element = 0;

            for (int i = 0; i < arr.Length - 1; i++)
                //arr.Length - 1 so we don't get out of the array
            {
                int currNum = arr[i];
                //2 -> arr[6];
                int nextNum = arr[i + 1];
                //2 -> arr[7];

                if (currNum == nextNum)
                //(Only for same elements 4 4 4 4)
                //We are making a verification if there is a sequence.
                {
                    length++;                   
                }
                else
                //if there is not we are resetting the length to 1
                //(arr.Length - 1)
                {
                    length = 1;
                    //(if legth = 0 we won't get the full size of the sequence)
                }

                if (length > counter)
                {
                    counter = length;
                    element = arr[i];
                }

            }

            for (int i = 0; i < counter; i++)
                //repeats counted times of sequence element.               
            {
                Console.Write($"{element} ");
                //2 2 2
            }
        }
    }
}

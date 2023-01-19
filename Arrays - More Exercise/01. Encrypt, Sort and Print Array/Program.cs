using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] sortedArray = new int[n];           

            for (int i = 0; i < n; i++)
            {
                char[] text = Console.ReadLine().ToArray();
                char[] vowels = { 'A', 'a', 'E', 'e', 'U', 'u', 'I', 'i', 'O', 'o' };
                int vowelsSum = text.Where(x => vowels.Contains(x)).Sum(x => x * text.Length);
                int consonantSum = text.Where(x => !vowels.Contains(x)).Sum(x => x / text.Length);
                sortedArray[i] = vowelsSum + consonantSum; 
            }

            //for (int i = 0; i < sortedArray.Length; i++)
            //{
            //    int[] currentSum = sortedArray.OrderBy(x => x).ToArray();
            //    Console.WriteLine(currentSum[i]);
            //}

            Console.WriteLine(String.Join(Environment.NewLine, sortedArray.OrderBy(x => x)));
        }
    }
}

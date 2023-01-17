using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the list of numbers from the input
            List<decimal> decimals = Console.ReadLine().Split().Select(decimal.Parse).ToList();   
            
            bool isValid = true;

            while (isValid)
            {
                isValid = false;
                for (int i = 0; i < decimals.Count - 1; i++)
                {
                    if (decimals[i] == decimals[i + 1])
                    {
                        decimals[i] += decimals[i + 1];
                        decimals.RemoveAt(i + 1);
                        i = -1;
                        isValid = true;
                        break;
                    }
                }
            }
            Console.WriteLine(String.Join(' ', decimals));
        }
    }
}

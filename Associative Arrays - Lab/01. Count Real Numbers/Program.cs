using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numberOcc = new Dictionary<double, int>();

            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (numberOcc.ContainsKey(number))
                {
                    //Dictionary -> Key -> Value
                    numberOcc[number] += 1;
                }
                else
                {
                    numberOcc.Add(number, 1);
                }               
            }

            foreach (var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
                      
        }
    }
}

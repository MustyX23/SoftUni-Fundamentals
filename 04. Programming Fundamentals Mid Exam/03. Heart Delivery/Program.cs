using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine())!= "Love!")
            {
                string[] commands = input.Split(' ');
                string action = commands[0];
                int length = int.Parse(commands[1]);

                if (action == "Jump")
                {
                    //TODO...
                }
            }
        }
    }
}

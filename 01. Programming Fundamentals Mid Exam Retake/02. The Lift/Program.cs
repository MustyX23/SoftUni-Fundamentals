using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i] < 4)
                {
                    if (people <= 0)
                    {
                        break;
                    }
                    wagons[i]++;
                    people--;                  
                }
            }
            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(' ', wagons));
            }
            else
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(' ', wagons));
            }

        }
    }
}

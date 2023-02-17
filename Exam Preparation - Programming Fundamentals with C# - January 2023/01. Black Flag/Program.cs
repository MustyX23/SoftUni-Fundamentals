using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double currentPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                currentPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    double additionalPlunder = dailyPlunder * 0.5;
                    currentPlunder += additionalPlunder;
                }
                if (i % 5 == 0)
                {
                    double lostPlunder = currentPlunder * 0.3;
                    currentPlunder -= lostPlunder;
                }
            }

            if (currentPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {currentPlunder:f2} plunder gained.");
            }
            else
            {
                double percentageLeft = currentPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentageLeft:f2}% of the plunder.");
            }

        }
    }
}

using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            double maxValue = double.MinValue;
            int endSnowball = 0;
            int endSnowballTime = 0;
            int endSnowballQuality = 0;

            while (counter < number)
            {
                int snowball = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                double formula = Math.Pow(snowball / snowballTime, snowballQuality);

                if (formula > maxValue)
                {
                    maxValue = formula;
                    endSnowball = snowball;
                    endSnowballTime = snowballTime;
                    endSnowballQuality = snowballQuality;
                }

                counter++;
            }
            Console.WriteLine($"{endSnowball} : {endSnowballTime} = {maxValue} ({endSnowballQuality})");
        }
    }
}

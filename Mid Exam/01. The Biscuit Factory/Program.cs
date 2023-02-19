using System;

public class BisquitsFactory
{
    public static void Main(string[] args)
    {
        int sum = 0;

        int bisquitsForAdayWorker = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int factoryCapacity = int.Parse(Console.ReadLine());

        for (int day = 1; day <= 30; day++)
        {
            int biscuitsForADay = bisquitsForAdayWorker * workers;
            if (day % 3 == 0)
            {
                biscuitsForADay = (int)(biscuitsForADay * 0.75);
            }
            sum += biscuitsForADay;
        }

        Console.WriteLine($"You have produced {sum} biscuits for the past month.");

        int differencec = Math.Abs(factoryCapacity - sum);
        double percentage = ((double)differencec / factoryCapacity) * 100;

        if (factoryCapacity > sum)
        {
            Console.WriteLine($"You produce {percentage:F2} percent less biscuits.");
        }
        else
        {
            Console.WriteLine($"You produce {percentage:F2} percent more biscuits.");
        }
    }
}

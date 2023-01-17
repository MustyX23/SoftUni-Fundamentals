using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxKeg = int.MinValue;
            string biggestModel = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (maxKeg < volume)
                {
                    maxKeg = volume;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}

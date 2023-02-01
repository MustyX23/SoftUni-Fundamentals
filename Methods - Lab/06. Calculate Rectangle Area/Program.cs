using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = ReactangleArea(width, height);
            Console.WriteLine(area);
        }
        static double ReactangleArea(double width, double height)
        {
            return width * height;
        }
    }
}

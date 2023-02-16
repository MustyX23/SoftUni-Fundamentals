using System;
using System.Collections.Generic;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double totalBonus;

            //The bonus is calculated with the following formula:
            //{total bonus} = {attendance} / {numberOfLectures} * (5 + {additional bonus})

            List<double> points = new List<double>();
            double[] attendance = new double[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                double num = int.Parse(Console.ReadLine());
                attendance[i] = num;
                totalBonus = attendance[i] / numberOfLectures * (5 + additionalBonus);
                points.Add(totalBonus);
            }

            //find the max points list
            double maxPoints = points[0];
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i] > maxPoints)
                {
                    maxPoints = points[i];
                }
            }



            int index = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i] == maxPoints)
                {
                    index = i;
                }
            }


            Console.WriteLine($"Max Bonus: {Math.Round(maxPoints)}.");
            Console.WriteLine($"The student has attended {attendance[index]} lectures.");
        }
    }
}

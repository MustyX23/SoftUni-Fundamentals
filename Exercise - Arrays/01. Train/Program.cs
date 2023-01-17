using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] rawPeople = new string[n];

            int sum = 0;
                       
            for (int i = 0; i < n; i++)
            {
                rawPeople[i] = Console.ReadLine();
                int people = int.Parse(rawPeople[i]);
                sum+= people;
            }
            Console.Write(string.Join(" ", rawPeople));
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}

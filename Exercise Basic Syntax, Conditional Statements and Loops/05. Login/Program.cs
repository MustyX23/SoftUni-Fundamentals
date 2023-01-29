using System;
using System.Linq;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            string input;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            int counter = 0;

            while ((input = Console.ReadLine()) != password)
            {
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                
                Console.WriteLine("Incorrect password. Try again.");
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}

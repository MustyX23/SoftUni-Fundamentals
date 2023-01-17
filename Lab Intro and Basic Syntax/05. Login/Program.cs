using System;
namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
                password += username[i];
            int failCount = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                failCount++;
                if (failCount == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }

        }
    }
}
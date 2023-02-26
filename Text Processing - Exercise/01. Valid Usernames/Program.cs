using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");

            List<string> validUsernames = new List<string>();

            for (int i = 0; i < userNames.Length; i++)
            {
                string user = userNames[i];
                if (user.Length >= 3 && user.Length <= 16)
                {
                    bool validUsername = ValidUserNames(user);
                    if (validUsername == true)
                    {
                        validUsernames.Add(user);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }

        static bool ValidUserNames(string user)
        {
            foreach (char c in user)
            {
                if (char.IsLetterOrDigit(c) || c == '-' || c == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        
    }
}

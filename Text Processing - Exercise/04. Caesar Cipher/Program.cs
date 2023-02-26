using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder encryptedMessage = new StringBuilder();

            foreach (char symbol in input)
            {
                char nextSymobl = (char)(symbol + 3);
                encryptedMessage.Append(nextSymobl);
            }

            Console.WriteLine(encryptedMessage);
        }
    }
}

using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string file = input.Substring(input.LastIndexOf('\\') + 1);

            int dotIndex = file.LastIndexOf('.');
            string fileName = file.Substring(0, dotIndex);
            string fileExtencion = file.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtencion}");
        }
    }
}

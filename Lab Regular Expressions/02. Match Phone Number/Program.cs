using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _02._Match_Phone_Number

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+(359)( |-)2\2\d{3}\2\d{4}\b";

            string phoneNumbers = Console.ReadLine();

            var matchcollection = Regex.Matches(phoneNumbers, pattern);

            List<string> listForPrint = new List<string>();

            foreach (Match item in matchcollection)
            {
                listForPrint.Add(item.Value);
            }

            Console.WriteLine(string.Join(", ", listForPrint));

        }
    }
}

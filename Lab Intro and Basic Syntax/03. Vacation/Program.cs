using System;
namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                    totalPrice = price * people;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                    totalPrice = price * people;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                    totalPrice = price * people;
                }
                if (people >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");

            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                    totalPrice = price * people;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                    totalPrice = price * people;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                    totalPrice = price * people;
                }
                if (people >= 100)
                {
                    people -= 10;
                    totalPrice = price * people;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                    totalPrice = price * people;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                    totalPrice = price * people;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                    totalPrice = price * people;
                }
                if (people >= 10 && people <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }

        }
    }
}

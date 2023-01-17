using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            //After it has been mined for a day, the yield drops by 10, meaning on the second day
            // => it’ll produce 10 less spice than on the first,
            // => on the third day 10 less than on the second, and so on...
            //A source is considered profitable only while its yield is at least 100.
            // => When less than 100 spices are expected in a day, abandon the source.
            //The mining crew consumes 26 spices every day.
            // => And an additional 26 after the mine has been exhausted
            // Workers cannot consume more spice than there is in storage. 
 
            int startingYield = int.Parse(Console.ReadLine());
            int consumedSpices = 0;
            int daysCounter = 0;
            int spicesLeft = 0;
            int lastTake = 0;
 

            while (startingYield >= 100)
            {              
                consumedSpices = startingYield - 26;
                spicesLeft += consumedSpices;
                startingYield -= 10;
                
                daysCounter++;
            }          
            
               lastTake = spicesLeft - 26;
            if (lastTake < 0)
            {
                lastTake = 0;
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(lastTake);
        }
    }
}

using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //The distance between the poke targets - M.
            int M = int.Parse(Console.ReadLine());
            //Poke power - N.
            int Y = int.Parse(Console.ReadLine());
            //The exhaustionFactor - Y.

            //reached a target and poked it

            int countPoked = 0;
            //COUNT how many targets you’ve poked – you’ll need that count.

            double originalValue = N * 0.50;

            while (M <= N)//(Until The Pokemon does not have enough power to reach the next target.)           
            {
                N = N - M;
                //start subtracting M from N until N becomes less than M
                countPoked++;

                if (M == originalValue)
                //IF N becomes equal to EXACTLY 50 % of its original value,
                {
                    if (Y > 0)
                    {
                        N /= N / Y;
                    }
                    // => you must divide N by Y, if it is POSSIBLE. 
                    if (N < M)
                    {
                        break;
                    }
                }
            }
            //When N becomes less than M,
            // => you must take what has remained of N and the count of targets you’ve poked,
            // => and print them as output.
            Console.WriteLine(N);
            Console.WriteLine(countPoked);


        }
    }
}

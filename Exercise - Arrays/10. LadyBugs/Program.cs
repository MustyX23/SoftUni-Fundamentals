using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Field
            //Array of Integers
            // 0 -> No LadyBug
            // 1 -> LadyBug
            int fieldSize = int.Parse(Console.ReadLine());

            int[] ladyBugsIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            //Initialize the field
            for (int index = 0; index < fieldSize; index++)
            {
                if (ladyBugsIndexes.Contains(index))
                {
                    //if Index is present in LadyBugs indexes, then there's a LadyBug
                    field[index] = 1; // -> LadyBug
                }
            }

            //Console.WriteLine(String.Join(' ', field)); -> Initialize the field

            string command;
            while ((command = Console.ReadLine())!= "end")
            {
                string[]cmdArgs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();

                int initialIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLentgh = int.Parse(cmdArgs[2]);

                //First always check if index is valid
                if (initialIndex < 0 || initialIndex >= field.Length)
                {
                    continue;
                }
                // We have valid index, then we check if there is a LadyBug

                if (field[initialIndex] == 0)
                {
                    continue;
                }

                //LadyBug starts flying.
                //Initial index is set to 0, because there is no LadyBug anymore.

                field[initialIndex] = 0;

                //Calculate where the next Index is 
                int nextIndex = initialIndex;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLentgh;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLentgh;
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        //Next Index is invalid (outside of the field)
                        //The LadyBug is gone to the void.
                        break;
                    }

                    if (field[nextIndex] == 0)
                    {
                        //The next index is valid to length.
                        //LadyBug lands there.
                        break;
                    }

                }
                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    //The next calculated index is valid.
                    //The LadyBug lands there.
                    field[nextIndex] = 1;
                }
            }

            Console.WriteLine(String.Join(' ', field));

        }
    }
}

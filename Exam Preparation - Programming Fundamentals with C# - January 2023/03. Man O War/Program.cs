using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will receive the status of the pirate ship, which is a string representing integer sections separated by ">".
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();

            //On the second line, you will receive the same type of status, but for the warship:
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();

            //On the third line, you will receive the maximum health capacity a section of the ship can reach.
            int maxHealth = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] command = input.Split(" ");

                string action = command[0];

                if (action == "Fire")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < warShip.Count)
                    {
                        int damage = int.Parse(command[2]);
                        if (damage > 0)
                        {
                            int health = warShip[index];
                            //the pirate ship attacks the warship with the given damage at that section.
                            //Check if the index is valid and if not, skip the command.

                            if (health >= damage)
                            {
                                warShip[index] = health - damage;
                            }
                            else
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);

                    if (startIndex >= 0 && endIndex >= 0 && startIndex < pirateShip.Count && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int health = pirateShip[i];
                            if (health >= damage)
                            {
                                pirateShip[i] = health - damage;
                            }
                            else
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (action == "Repair")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < pirateShip.Count)
                    {
                        int health = pirateShip[index];
                        if (health + int.Parse(command[2]) <= maxHealth)
                        {
                            pirateShip[index] = health + int.Parse(command[2]);
                        }
                        else
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Status")
                {
                    //prints the count of all sections of the pirate ship that need repair soon, which are all sections that are lower than 20% of the maximum health capacity. 
                    int count = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < maxHealth * 0.2)
                        {
                            count++;
                        }
                    }
                    //"{count} sections need repair."
                    Console.WriteLine($"{count} sections need repair.");
                }

            }

            //if stalemate occurs print the status of both ships, which is the sum of their individual sections

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");




        }
    }
}

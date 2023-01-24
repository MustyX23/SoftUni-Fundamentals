using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split("_");
                //favourite_DownTown_3:14 ->
                //token[0] - typeList | token[1] - name | token[2] - time 

                string typeList = token[0];
                string name = token[1];
                string time = token[2];

                Song song = new Song (typeList, name, time);
                songs.Add (song);
            }

            string command = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                Song currentSong = songs[i];
                if (command == "all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                if (command == currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
            
        }
    }


}

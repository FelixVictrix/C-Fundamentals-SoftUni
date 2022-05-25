using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numOfSongs; i++)
            {
                string[] currSong = Console.ReadLine().Split('_');
                string type = currSong[0];
                string name = currSong[1];
                string time = currSong[2];

                var song = new Song(type, name, time);
                songs.Add(song);
            }
            string printType = Console.ReadLine();

            if (printType == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var sing in songs.Where(x => x.TypeList == printType))
                {
                    Console.WriteLine(sing.Name);
                }
            }

        }

    }
    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}

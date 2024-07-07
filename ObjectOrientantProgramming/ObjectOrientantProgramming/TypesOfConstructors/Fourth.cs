using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientantProgramming.TypesOfConstructors
{
    public class Fourth
    {
        private static int TotalArtist;
        //Auto-implementing property
        public string Artist { get; set; } = string.Empty;


        //Static Constructor
        static Fourth()
        {
            Console.WriteLine("Calling static constructor");
            TotalArtist = 0;
        }

        //public Fourth(string artist)
        //{
        //    Artist = artist;
        //    //Incrementing everytime we add an artist
        //    TotalArtist++;
        //}

    }
}

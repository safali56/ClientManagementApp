
///<summary>
///    I,  Safali BC Senchuri certify that this material is my original work.  No other person's work has been used without due acknowledgement.
///</summary>

///<summary>
/// The <c>Song</c> is a type of media class that manages the meta details on artist and their albums
/// It has no encryption 
///</summary>
///<author> Safali BC Senchuri(000931218)</author>
///<date>11/10/2024.</date>
///<version>1.0</version>
///

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Song : Media
    {

        public string Artist { get; set; }
        public string Album { get; set; }

        public Song(string title, int year, string album, string artist) : base(title, year)
        {
            Artist = artist;
            Album = album;
        }

        //public bool Search(string key)
        //{
            //return (key.StartsWith("SONG"));
        //}

        public override string ToString()
        {
            return $@"Song Title: {Title} ({Year}).
                Artist: {Artist}.
                        Album Title: {Album}.
                --------------------
                ";
        }

    }
}


///<summary>
///    I, Safali BC Senchuri, 000931218certify that this material is my original work.  No other person's work has been used without due acknowledgement.
///</summary>

///<summary>
/// The <c>Program.cs</c> is the main program that handles the operation  on each of the media type
/// (Book, Movie and Song)
///summary>
///<author>Safali BC Senchuri, 000931218</author>
///<date>11/10/2024.</date>
///<version>1.0</version>
///

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Program
    {

        static void Main(string[] args)
        {


            //Continuosly taking inputs from the user to view any media contents, as long as the input is appropriate
            while(true)
            {
                Media[] mediaItems = ReadData();

                Console.Write(@"
                Peace's Media Collection                                                                                                                             
                =======================                                                                                                                             
                1. List All Books                                                                                                                                   
                2. List All Movies                                                                                                                                  
                3. List All Songs                                                                                                                                   
                4. List All Media                                                                                                                                   
                5. Search All Media by Title                                                                                                                        
                                                                                                                                                    
                6. Exit Program
                ");

                try
                {

                    Console.Write("Enter a Choice: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == 6)
                    {
                        Console.WriteLine("Good bye! Do have a wonderful day.");
                        break;
                    }

                    switch (input)
                    {
                        case 1:
                            ListBooks(mediaItems);
                            break;
                        case 2:
                            ListMovies(mediaItems);
                            break;
                        case 3:
                            ListSongs(mediaItems);
                            break;
                        case 4:
                            ListAllMedia(mediaItems);
                            break;
                        case 5:
                            Console.WriteLine("Search by title:");
                            string searchTitle = Console.ReadLine();
                            ListAllMediaByTitle(mediaItems, searchTitle);
                            break;
                        default:
                            Console.WriteLine("This is not a valid input try again by using the above menu options as provided!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, enter an appropriate numeric value!");
                    continue;
                }
            }

        }


        /// <summary>
        /// ReadData Method retrieves an array of the media types ranging from Book, Song and Movie
        /// </summary>
        /// <returns>Media items</returns>
        public static Media[] ReadData()
        {

            Media[] mediaData = new Media[100];
            string[] mediaItems;
            Book book = null;
            Movie movie = null;
            Song song = null;

            try
            {    //open and access the 'data.txt'
                string line;
                FileStream file = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                StreamReader data = new StreamReader(file);

                int index = 0;
                while ((line = data.ReadLine()) != null)
                {
                    if (line.StartsWith("BOOK"))
                    {
                        mediaItems = GetMediaItem(line);
                        book = new Book(mediaItems[1], Convert.ToInt32(mediaItems[2]), mediaItems[3]);
                        while ((line = data.ReadLine()) != null &&  !(line.StartsWith("-----")))
                        {
                            book.Summary += line;
                        }
                        mediaData[index] = book;
                    }
                    else if (line.StartsWith("MOVIE"))
                    {
                        mediaItems = GetMediaItem(line);
                        movie = new Movie(mediaItems[1], Convert.ToInt32(mediaItems[2]), mediaItems[3]);
                        while ((line = data.ReadLine()) != null && !(line.StartsWith("-----")))
                        {
                            movie.Summary += line;
                        }
                        mediaData[index] = movie;
                    }
                    else if (line.StartsWith("SONG"))
                    {
                        mediaItems = GetMediaItem(line);
                        mediaData[index] = new Song(mediaItems[1], Convert.ToInt32(mediaItems[2]), mediaItems[3], mediaItems[4]);
                    }
                    index++;
                    }

                data.Close();
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Oops! Seems file is missing. Try checking the path.");
            }

            return mediaData;
        }


        public static string[] GetMediaItem(string item)
        {
            string[] arr = { "", };
            if (item.StartsWith("BOOK") || item.StartsWith("MOVIE") || item.StartsWith("SONG"))
            {
                return item.Split('|');
            }
            return arr;
        }


        /// <summary>
        /// This Method list all the Books available without its summary
        /// </summary>
        ///<param name="mediaItems" >Array of Media Items</param>
        public static void ListBooks(Media[] mediaItems)
        {
            foreach (Media mediaItem in mediaItems)
            {
                if (mediaItem is Book)
                {
                    Book book = (Book)mediaItem;
                    Console.WriteLine($@"
                {book.ToString()}
                ");
                }
            }
        }


        /// <summary>
        /// This Method list and prints out all the Movies available without its summary
        /// </summary>
        ///<param name="mediaItems" >Array of Media Items</param>
        public static void ListMovies(Media[] mediaItems)
            {
                foreach (Media mediaItem in mediaItems)
                {
                    if (mediaItem is Movie)
                    {
                        Movie movie = (Movie)mediaItem;
                        Console.WriteLine($@"
            {movie.ToString()}
            ");
                    }
                }
            }

        /// <summary>
        /// This Method list all the Songs available
         ///</summary>
        ///<param name="mediaItems" >Array of Media Items</param>
        public static void ListSongs(Media[] mediaItems)
            {
                foreach (Media mediaItem in mediaItems)
                {
                    if (mediaItem is Song)
                    {
                        Song song = (Song)mediaItem;
                        Console.WriteLine($@"
            {song.ToString()}
                ");
                    }
                }
            }


        /// <summary>
        /// This Method list all the media types available along side  their  decrypted summary if available base on the specified title
        /// </summary>
        ///<param name="mediaItems" >Array of Media Items</param>
        public static void ListAllMedia(Media[] mediaItems)
        {
            foreach (Media mediaItem in mediaItems)
            {
                if (mediaItem is Book)
                {
                    Book book = (Book)mediaItem;
                    Console.WriteLine($@"
                {book.ToString()}
                ");
                }
                else if (mediaItem is Movie)
                {
                    Movie movie = (Movie)mediaItem;
                    Console.WriteLine($@"
            {movie.ToString()}
            ");
                }
                else if (mediaItem is Song)
                {
                    Song song = (Song)mediaItem;
                    Console.WriteLine($@"
            {song.ToString()}
                ");
                }
            }
        }


        public static void ListAllMediaByTitle(Media[] mediaItems, string title)
        {
            foreach (Media mediaItem in mediaItems)
            {
                if (mediaItem is Book && mediaItem.Search(title))
                {
                    Book book = (Book)mediaItem;
                    Console.WriteLine($@"
                {book.ToString()}
            Summary: {book.Decrypt()}
                ");
                }
                else if (mediaItem is Movie && mediaItem.Search(title))
                {
                    Movie movie = (Movie)mediaItem;
                    Console.WriteLine($@"
            {movie.ToString()}
            Summary: {movie.Decrypt()}
            ");
                }
                else if (mediaItem is Song && mediaItem.Search(title))
                {
                    Song song = (Song)mediaItem;
                    Console.WriteLine($@"
            {song.ToString()}
                ");
                }
            }
        }



    }
}

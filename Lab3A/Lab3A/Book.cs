///<summary>
///    I, Safali BC Senchuri, 000931218 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
///</summary>

///<summary>
/// The <c>Book </c> is a type of media class that manages the meta details on author and book summary
/// It has methods that decrypts its encrypted summary
///</summary>
///<author> Safali BC Senchuri (000931218)</author>
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
    internal class Book : Media, IEncryptable
    {

        public string Author { get; set; }
        public string Summary { get; set; }

        public Book(string title, int year, string author, string summary="") : base(title, year)
        {
            Author = author;
            Summary = summary;
        }

        //public bool Search(string key)
        //{
            //return false; //key.StartsWith("BOOK");
        //}

        public string Decrypt()
        {
            string decryptedSummary = "";
            foreach(char character in Summary) {
                if(char.IsUpper(character) && character < 'N')
                    decryptedSummary += Convert.ToChar(character + 13);
                else if (char.IsUpper(character) && character > 'M')
                    decryptedSummary += Convert.ToChar(character - 13);
                else if (char.IsLower(character) && character < 'n')
                    decryptedSummary += Convert.ToChar(character + 13);
                else if (char.IsLower(character) && character > 'm')
                    decryptedSummary += Convert.ToChar(character - 13);
                else
                    decryptedSummary += character ;
            }
            return decryptedSummary;
        }

        public string Encrypt()
        {
            string encryptedSummary = "";
            foreach (char character in Summary)
            {
                if (char.IsUpper(character) && character < 'N')
                    encryptedSummary += Convert.ToChar(character + 13);
                else if (char.IsUpper(character) && character > 'M')
                    encryptedSummary += Convert.ToChar(character - 13);
                else if (char.IsLower(character) && character < 'n')
                    encryptedSummary += Convert.ToChar(character + 13);
                else if (char.IsLower(character) && character > 'm')
                    encryptedSummary += Convert.ToChar(character - 13);
                else
                    encryptedSummary += character;
            }
            return encryptedSummary;
        }

        public override string ToString()
        {
            return $@"Book Title: {Title} ({Year}).
                Author: {Author}.
                --------------------
                ";
        }

    }
}

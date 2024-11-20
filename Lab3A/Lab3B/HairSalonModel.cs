///<summary>
///    I, Safali BC Senchuri, 000931218 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
///</summary>

///<summary>
/// The <c>Model</c> class manages the operations on the perfect cut hair salon
/// It offers static methods to handle the kind of services customer requires from the salon
///</summary>
///<author> Safali BC Senchuri, 000931218</author>
///<date>11/10/2024.</date>
///<version>2.0</version>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2B
{
    internal class HairSalonModel
    {

        /* *
         * Get the price from a selected hair dresser
         * @param hairDresser (string) name of hair dresser.
         * @return price (decimal)  fee charged.
         * */
        public static decimal GetHairDresserFee(string hairDresser)
        {
            decimal price = 0M;
            char hairDresserFirstLetter = hairDresser[0];
            /* *determine the fee charge by the hair dresser in request */
            switch(hairDresserFirstLetter)
            {
                case 'J':
                    price  = 30M ;
                    break;
                case 'P':
                    price = 45M;
                    break;
                case 'R':
                    price = 40M;
                    break;
                case 'S':
                    price = 50M;
                    break;
                case 'L':
                    price = 55M;
                    break;
                default:
                    price = 0M;
                    break;
            }
            return price;
        }


        /* *
 * Get the price from a selected Service
 * @param service (string) type of service required.
 * @return price (decimal)  fee charged.
 * */
        public static decimal GetServiceFee(string service)
        {
            decimal price = 0M;
            char serviceFirstLetter = (service[1] == 'u') ? 'u' : service[0];
            /* *determine the service fee charged as requested */
            switch (serviceFirstLetter)
            {
                case 'u':
                    price = 30M;
                    break;
                case 'C':
                    price = 40M;
                    break;
                case 'H':
                    price = 50M;
                    break;
                case 'E':
                    price = 200M;
                    break;
                case 'W':
                    price = 20M;
                    break;
                case 'U':
                    price = 60M;
                    break;
                default:
                    price = 0M;
                    break;
            }
            return price;
        }



    }
}

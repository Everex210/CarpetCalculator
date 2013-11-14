using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarpetCalculator
{
    class Program
    {
        static void Main( )
        {
            //Declare constant variables
            const int SQ_FT_PER_SQ_YARD = 9;
            const int INCHES_PER_FOOT = 12;
            const string BEST_CARPET = "Berber";
            const string ECONOMY_CARPET = "Pile";

            //Declare integers
            int roomLengthFeet = 12,
                roomLengthInches = 2,
                roomWidthFeet = 14,
                roomWidthInches = 7;

            //Declare double intgers
            double roomLength,
                   roomWidth,
                   carpetPrice,
                   numOfSquareFeet,
                   numOfSquareYards,
                   totalCost;

            //Convert to square feet from square inches
            roomLength = (Double)(roomLengthFeet +
                roomLengthInches / INCHES_PER_FOOT);
            /* roomLength is an example of an explicit cast to Double */
            /* roomWidth is an example of an implicit cast to Double */
            roomWidth = roomWidthFeet +
                roomWidthInches / INCHES_PER_FOOT;
            numOfSquareFeet = roomLength * roomWidth;
            numOfSquareYards = numOfSquareFeet /
                SQ_FT_PER_SQ_YARD;

            //Show the prices of the different types of carpet
            carpetPrice = 27.95;
            totalCost = numOfSquareYards * carpetPrice;
            Console.WriteLine("The cost of " + "{0:###.##}" + " square yards of "
                + BEST_CARPET +
                " is {1:C}.",numOfSquareYards, totalCost);

            Console.WriteLine();
            carpetPrice = 15.95;
            totalCost = numOfSquareYards * carpetPrice;
            Console.WriteLine("The cost of {0:###.##} square yards of " + ECONOMY_CARPET + " is " + "{1:C}.", numOfSquareYards,totalCost);

            Console.WriteLine("\nPress enter to close this window.");
            Console.Read();

        }
    }
}

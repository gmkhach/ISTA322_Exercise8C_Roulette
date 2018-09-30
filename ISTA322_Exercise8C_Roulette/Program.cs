using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise8C_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
        Run();
        }

        private static void Run()
        {
            // 37 represents 00
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37 };
            string[] colors = { "green", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black", "red", "black", "red", "black", "red", "black", "red", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black", "red", "black", "red", "black", "red", "black",  "red", "green" };
            RouletteWheel myWheel = new RouletteWheel(numbers);
            int number = myWheel.Spin();
            CalcWinningBids(number, colors[number]);
        }

        private static void CalcWinningBids(int number, string colors)
        {
            string winningBin = Convert.ToString(number);
            if (number == 37)
            {
                winningBin = "00";
            }

            string evenOdd = "odd";
            if (winningBin == "00" || number % 2 == 0)
            {
                evenOdd = "even";
            }

            string lowHigh = "high";
            if (winningBin == "00" || number <= 18)
            {
                lowHigh = "low";
            }

            string dozen = "3rd 12";
            if (winningBin == "00" || number <= 12)
            {
                dozen = "1st 12";
            }
            else if (number > 12 && number < 25)
            {
                dozen = "2nd 12";
            }

            string column = "3rd";
            if (number % 3 == 1)
            {
                column = "1st";
            }
            else if (number % 3 == 2)
            {
                column = "2nd";
            }

            string street = "";
            int remainder = number % 3;
            if (number == 0 || number == 37)
            {
                street = $"{winningBin}";
            }
            else if (remainder == 0)
            { 
                street = $"{number - 2}/{number - 1}/{number}";
            }
            else if (remainder == 1 && remainder !=37)
            {
                street = $"{number}/{number + 1}/{number + 2}";
            }
            else if (remainder == 2)
            {
                street = $"{number - 1}/{number}/{number + 1}";
            }

            string sixNumbers;
            if (number == 0 || number == 37)
            {
                sixNumbers = $"{winningBin}";
            }
            else if (number == 34)
            {
                sixNumbers = "31/32/33/34/35/36";
            }
            else if (remainder == 0 && (number != 1 || number != 34))
            {
                sixNumbers = $"{number - 5}/{number - 4}/{number - 3}/{number - 2}/{number - 1}/{number}, {number - 2}/{number - 1}/{number}/{number + 1}/{number + 2}/{number + 3}";
            }
            else if (remainder == 1 && number != 37)
            {
                sixNumbers = $"{number - 3}/{number - 2}/{number - 1}/{number}/{number + 1}/{number + 2}, {number}/{number + 1}/{number + 2}/{number + 3}/{number + 4}/{number + 5}";
            }
            else
            {
                sixNumbers = $"{number - 4}/{number - 3}/{number - 2}/{number - 1}/{number}/{number + 1}, {number - 1}/{number}/{number + 1}/{number + 2}/{number + 3}/{number + 4}";
            }

            string split = "";
            if (number == 0 || number == 37)
            {
                split = $"{winningBin}";
            }
            else if (number < 4)
            {
                if (remainder == 0)
                {
                    split = $"{number - 1}/{number}, {number}/{number + 3}";
                }
                else if (remainder == 1 && number != 37)
                {
                    split = $"{number}/{number + 1}, {number}/{number + 3}";
                }
                else
                {
                    split = $"{number - 1}/{number}, {number}/{number + 1}, {number}/{number + 3}";
                }
            }
            else if (number > 33)
            {
                if (remainder == 0)
                {
                    split = $"{number - 3}/{number}, {number - 1}/{number}";
                }
                else if (remainder == 1 && number != 37)
                {
                    split = $"{number -3}/{number}, {number}/{number + 1}";
                }
                else
                {
                    split = $"{number - 3}/{number}, {number -1}/{number}, {number}/{number + 1}";
                }
            }
            else if (remainder == 0)
            {
                split = $"{number - 3}/{number}, {number - 1}/{number}, {number}/{number + 3}";
            }
            else if (remainder == 1)
            {
                split = $"{number - 3}/{number}, {number}/{number + 1}, {number}/{number + 3}";
            }
            else
            {
                    split = $"{number - 3}/{number}, {number - 1}/{number}, {number}/{number + 1}, {number}/{number + 3}";
            }


            string corner = "";
            if (number == 0 || number == 37)
            {
                corner = $"{winningBin}";
            }
            else if (number < 4)
            {
                if (remainder == 0)
                {
                    corner = $"{number - 1}/{number}/{number + 2}/{number + 3}";
                }
                else if (remainder == 1)
                {
                    corner = $"{number}/{number + 1}/{number + 3}/{number + 4}";
                }
                else
                {
                    corner = $"{number - 1}/{number}/{number + 2}/{number + 3}, {number}/{number + 1}/{number + 3}/{number + 4}";
                }
            }
            else if (number > 33)
            {
                if (remainder == 0)
                {
                    corner = $"{number - 4}/{number - 3}/{number - 1}/{number}";
                }
                else if (remainder == 1)
                {
                    corner = $"{number - 3}/{number - 2}/{number}/{number + 1}";
                }
                else
                {
                    corner = $"{number - 4}/{number - 3}/{number - 1}/ {number}, {number - 3}/{number - 2}/{number}/{number + 1}";
                }
            }
            else if (remainder == 0)
            {
                corner = $"{number - 4}/{number -3}/{number - 1}/{number}, {number - 1}/{number}/{number + 2}/{number + 3}";
            }
            else if (remainder == 1)
            {
                corner = $"{number - 3}/{number - 2}/{number}/{number + 1}, {number}/{number + 1}/{number + 3}/{number + 4}";
            }
            else
            {
                corner = $"{number - 4}/{number - 3}/{number - 1}/ {number}, {number - 3}/{number - 2}/{number}/{number + 1}, {number -1}/{number}/{number + 2}/{number + 3}, {number}/{number + 1}/{number +3}/{number + 4}";
            }

            Console.WriteLine($"\nWinning bin:\t{winningBin} {colors}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Numbers:\t{winningBin}");
            Console.WriteLine($"\nEvens/Odds:\t{evenOdd}");
            Console.WriteLine($"\nReds/Blacks:\t{colors}");
            Console.WriteLine($"\nLows/Highs:\t{lowHigh}");
            Console.WriteLine($"\nDozens:\t\t{dozen}");
            Console.WriteLine($"\nColumns:\t{column}");
            Console.WriteLine($"\nStreets:\t{street}");
            Console.WriteLine($"\n6 Numbers:\t{sixNumbers}");
            Console.WriteLine($"\nSplit:\t\t{split}");
            Console.WriteLine($"\nCorner:\t\t{corner}");
            Console.WriteLine();
        }
    }
}
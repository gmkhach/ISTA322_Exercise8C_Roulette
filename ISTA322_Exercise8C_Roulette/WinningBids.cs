using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise8C_Roulette
{
    class WinningBids
    {
        public WinningBids(int number, string color)
        {
            this.n = number;
            this.remainder = number % 3;
            this.winningBin = Convert.ToString(number);
            this.color = color;
        }

        private int n;
        private int remainder;
        private string color;
        private string winningBin;

        public void WinningBin()
        {
            string winningBin = Convert.ToString(n);
            if (n == 37)
            {
                winningBin = "00";
            }
            Console.WriteLine($"Numbers:\t{winningBin}");
        }

        public void EvenOdd()
        {
            string evenOdd = "odd";
            if (winningBin == "00" || n % 2 == 0)
            {
                evenOdd = "even";
            }
            Console.WriteLine($"\nEvens/Odds:\t{evenOdd}");
        }

        public void RedBlack()
        {
            Console.WriteLine($"\nReds/Blacks:\t{color}");
        }

        public void LowHigh()
        {
            string lowHigh = "high";
            if (winningBin == "00" || n <= 18)
            {
                lowHigh = "low";
            }
            Console.WriteLine($"\nLows/Highs:\t{lowHigh}");
        }

        public void Dozens()
        {
            string dozen = "3rd 12";
            if (winningBin == "00" || n <= 12)
            {
                dozen = "1st 12";
            }
            else if (n > 12 && n < 25)
            {
                dozen = "2nd 12";
            }
            Console.WriteLine($"\nDozens:\t\t{dozen}");

        }

        public void Columns()
        {
            string column = "3rd";
            if (n % 3 == 1)
            {
                column = "1st";
            }
            else if (n % 3 == 2)
            {
                column = "2nd";
            }
            Console.WriteLine($"\nColumns:\t{column}");
        }

        public void Streets()
        {
            string street = "";
            if (n == 0 || n == 37)
            {
                street = $"{winningBin}";
            }
            else if (remainder == 0)
            {
                street = $"{n - 2}/{n - 1}/{n}";
            }
            else if (remainder == 1 && remainder != 37)
            {
                street = $"{n}/{n + 1}/{n + 2}";
            }
            else if (remainder == 2)
            {
                street = $"{n - 1}/{n}/{n + 1}";
            }

            Console.WriteLine($"\nStreets:\t{street}");
        }

        public void SixNumbers()
        {
            string sixNumbers;
            if (n == 0 || n == 37)
            {
                sixNumbers = $"{winningBin}";
            }
            else if (n == 34)
            {
                sixNumbers = "31/32/33/34/35/36";
            }
            else if (remainder == 0 && (n != 1 || n != 34))
            {
                sixNumbers = $"{n - 5}/{n - 4}/{n - 3}/{n - 2}/{n - 1}/{n}, {n - 2}/{n - 1}/{n}/{n + 1}/{n + 2}/{n + 3}";
            }
            else if (remainder == 1 && n != 37)
            {
                sixNumbers = $"{n - 3}/{n - 2}/{n - 1}/{n}/{n + 1}/{n + 2}, {n}/{n + 1}/{n + 2}/{n + 3}/{n + 4}/{n + 5}";
            }
            else
            {
                sixNumbers = $"{n - 4}/{n - 3}/{n - 2}/{n - 1}/{n}/{n + 1}, {n - 1}/{n}/{n + 1}/{n + 2}/{n + 3}/{n + 4}";
            }

            Console.WriteLine($"\n6 Numbers:\t{sixNumbers}");

        }

        public void Split()
        {
            string split = "";
            if (n == 0 || n == 37)
            {
                split = $"{winningBin}";
            }
            else if (n < 4)
            {
                if (remainder == 0)
                {
                    split = $"{n - 1}/{n}, {n}/{n + 3}";
                }
                else if (remainder == 1 && n != 37)
                {
                    split = $"{n}/{n + 1}, {n}/{n + 3}";
                }
                else
                {
                    split = $"{n - 1}/{n}, {n}/{n + 1}, {n}/{n + 3}";
                }
            }
            else if (n > 33)
            {
                if (remainder == 0)
                {
                    split = $"{n - 3}/{n}, {n - 1}/{n}";
                }
                else if (remainder == 1 && n != 37)
                {
                    split = $"{n - 3}/{n}, {n}/{n + 1}";
                }
                else
                {
                    split = $"{n - 3}/{n}, {n - 1}/{n}, {n}/{n + 1}";
                }
            }
            else if (remainder == 0)
            {
                split = $"{n - 3}/{n}, {n - 1}/{n}, {n}/{n + 3}";
            }
            else if (remainder == 1)
            {
                split = $"{n - 3}/{n}, {n}/{n + 1}, {n}/{n + 3}";
            }
            else
            {
                split = $"{n - 3}/{n}, {n - 1}/{n}, {n}/{n + 1}, {n}/{n + 3}";
            }
            Console.WriteLine($"\nSplit:\t\t{split}");
        }

        public void Corner()
        {
            string corner = "";
            if (n == 0 || n == 37)
            {
                corner = $"{winningBin}";
            }
            else if (n < 4)
            {
                if (remainder == 0)
                {
                    corner = $"{n - 1}/{n}/{n + 2}/{n + 3}";
                }
                else if (remainder == 1)
                {
                    corner = $"{n}/{n + 1}/{n + 3}/{n + 4}";
                }
                else
                {
                    corner = $"{n - 1}/{n}/{n + 2}/{n + 3}, {n}/{n + 1}/{n + 3}/{n + 4}";
                }
            }
            else if (n > 33)
            {
                if (remainder == 0)
                {
                    corner = $"{n - 4}/{n - 3}/{n - 1}/{n}";
                }
                else if (remainder == 1)
                {
                    corner = $"{n - 3}/{n - 2}/{n}/{n + 1}";
                }
                else
                {
                    corner = $"{n - 4}/{n - 3}/{n - 1}/ {n}, {n - 3}/{n - 2}/{n}/{n + 1}";
                }
            }
            else if (remainder == 0)
            {
                corner = $"{n - 4}/{n - 3}/{n - 1}/{n}, {n - 1}/{n}/{n + 2}/{n + 3}";
            }
            else if (remainder == 1)
            {
                corner = $"{n - 3}/{n - 2}/{n}/{n + 1}, {n}/{n + 1}/{n + 3}/{n + 4}";
            }
            else
            {
                corner = $"{n - 4}/{n - 3}/{n - 1}/ {n}, {n - 3}/{n - 2}/{n}/{n + 1}, {n - 1}/{n}/{n + 2}/{n + 3}, {n}/{n + 1}/{n + 3}/{n + 4}";
            }
            Console.WriteLine($"\nCorner:\t\t{corner}");
        }

    }
}

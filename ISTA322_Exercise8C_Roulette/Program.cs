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
            int winningNumber = myWheel.Spin();
            string winningBin = Convert.ToString(winningNumber);
            if (winningNumber == 37)
            {
                winningBin = "00";
            }
            CalcWinningBids(winningBin, colors[winningNumber]);
        }

        private static void CalcWinningBids(string winningBin, string colors)
        {
            Console.WriteLine($"\nWinning bin:\t{winningBin} {colors}");
            Console.WriteLine($"\nNumbers:\t\t{winningBin}");
            Console.WriteLine($"\nEvens/Odds:\t");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
        }
    }
}
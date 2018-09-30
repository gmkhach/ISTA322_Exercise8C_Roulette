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
            string[] colors = { "green", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black", "red", "black", "red", "black", "red", "black", "red", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black", "red", "black", "red", "black", "red", "black", "red", "green" };
            RouletteWheel myWheel = new RouletteWheel(numbers);
            bool keepLooping = true;
            do
            {
                int number = myWheel.Spin();
                CalcWinningBids(number, colors[number]);
                bool innerLoop = true;
                do
                {
                    try
                    {
                        Console.Write("\nDo you want to spin again? Y/N\n\n>>> ");
                        string input = Console.ReadLine();
                        if (input == "N" || input == "n")
                        {
                            innerLoop = false;
                            keepLooping = false;
                        }
                        else if (input == "Y" || input == "y")
                        {
                            innerLoop = false;
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            throw new Exception("\nInvalid entry!");
                        }
                        Console.Clear();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (innerLoop);
            } while (keepLooping);
        }

        private static void CalcWinningBids(int number, string color)
        {
            string winningBin = Convert.ToString(number);
            WinningBids bin = new WinningBids(number, color);
            Console.WriteLine($"\nWinning bin:\t{winningBin} {color}");
            Console.WriteLine("-------------------------");
            bin.WinningBin();
            bin.EvenOdd();
            bin.RedBlack();
            bin.LowHigh();
            bin.Dozens();
            bin.Columns();
            bin.Streets();
            bin.SixNumbers();
            bin.Split();
            bin.Corner();
        }
    }
}
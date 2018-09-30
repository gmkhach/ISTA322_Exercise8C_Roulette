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

        public static void Run()
        {
            // 37 represents 00
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37 };
            string[] colors = { "black", "red", "green" };
            RouletteWheel myWheel = new RouletteWheel(numbers);
            myWheel.Spin();
        }
    }
}
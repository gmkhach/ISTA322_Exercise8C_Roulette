using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322_Exercise8C_Roulette
{
    class RouletteWheel
    {
        public RouletteWheel(int[] numbers)
        {
            string color;
            for (int i = 0; i < 38; i++)
            {
                if (i == 0 || i == 37)
                {
                    color = "green";
                }
                else if (((i < 11 || (i > 19 && i < 29)) && i % 2 == 0) || (((i > 10 && i < 18) || i > 28) && i % 2 == 1))
                {
                    color = "black";
                }
                else
                {
                    color = "red";
                }
                bins[i] = new Bin(numbers[i], color);
            }
        }
        private Bin[] bins = new Bin[38];
        private Random rnd = new Random();

        public int Spin()
        {
            return rnd.Next(38);
        }
    }
}

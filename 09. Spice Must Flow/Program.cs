using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {

            // total amount of spice
            // starting yield, which indicates how much spice can be mined on the first day.
            // After it has been mined for a day, the yield drops by 10, he second day it’ll produce 10 less spice than on the first,
            //  considered profitable only while its yield is at least 100 , less than 100 spice is expected in a day, abandon the source.
            //mining crew consumes 26 spice every day , an additional 26 after the mine has been exhausted

            int startingYield = int.Parse(Console.ReadLine());

            int totalExtracted = 0;
            int daysCount = 0;

            if (startingYield > 0)
            {
                while (startingYield >= 100)
                {
                    totalExtracted += startingYield - 26;
                    startingYield -= 10;
                    daysCount++;
                }

            }

            if (daysCount > 0)
            {
                totalExtracted -= 26;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(totalExtracted);
        }
    }
}

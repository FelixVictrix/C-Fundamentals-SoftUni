using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> raceList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double leftTime = 0;
            double rightTime = 0;
            int endOfTheRace = raceList.Count / 2;

            for (int i = 0; i < endOfTheRace; i++)
            {
                leftTime += raceList[i];
                rightTime += raceList[raceList.Count - 1 - i];

                if (raceList[i] == 0)
                {
                    leftTime *= 0.8;
                }

                if (raceList[raceList.Count - 1 - i] == 0)
                {
                    rightTime *= 0.8;
                }

            }

            if (leftTime < rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {(float)leftTime}");
            }
            else if (rightTime < leftTime)
            {
                Console.WriteLine($"The winner is right with total time: {(float)rightTime}");
            }
        }
    }
}

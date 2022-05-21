using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombIndex = bomb[0];
            int power = bomb[1];

            for (int i = 0; i < list.Count - 1; i++)
            {
                int currNum = list[i];
                if (currNum == bombIndex)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > list.Count - 1)
                    {
                        endIndex = list.Count - 1;
                    }

                    int explosionArea = endIndex - startIndex + 1;
                    list.RemoveRange(startIndex, explosionArea);
                    i = startIndex - 1;
                }
            }

            Console.WriteLine(list.Sum());
        }
    }
}

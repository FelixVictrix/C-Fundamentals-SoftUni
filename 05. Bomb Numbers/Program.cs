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

            if (bomb.Sum() < list.Count)
            {
             
            }
        }
    }
}

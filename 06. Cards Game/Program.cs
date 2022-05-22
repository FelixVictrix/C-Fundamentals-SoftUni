using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> firstHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < firstHand.Count; i++)
            {
                int firstHandCard = firstHand[i];
                int secondHandCard = secondHand[i];

                if (firstHandCard == secondHandCard)
                {
                    firstHand.Remove(firstHandCard);
                    secondHand.Remove(secondHandCard);
                }
                else if (firstHandCard > secondHandCard)
                {
                    firstHand.Add(firstHandCard);
                    firstHand.Add(secondHandCard);
                    firstHand.Remove(firstHand[i]);
                    secondHand.Remove(secondHand[i]);
                }
                else if (firstHandCard < secondHandCard)
                {
                    secondHand.Add(secondHandCard);
                    secondHand.Add(firstHandCard);
                    secondHand.Remove(secondHand[i]);
                    firstHand.Remove(firstHand[i]);
                }

            }

            Console.WriteLine($"");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST
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

            while (firstHand.Any() && secondHand.Any())
            {

                int firstCard = firstHand[0];
                int secondCard = secondHand[0];

                if (firstCard == secondCard)
                {
                    firstHand.Remove(firstCard);
                    secondHand.Remove(secondCard);
                }
                else if (firstCard > secondCard)
                {
                    firstHand.Add(firstCard);
                    firstHand.Add(secondCard);
                    firstHand.Remove(firstHand[0]);
                    secondHand.Remove(secondHand[0]);
                }
                else if (firstCard < secondCard)
                {
                    secondHand.Add(secondCard);
                    secondHand.Add(firstCard);
                    secondHand.Remove(secondHand[0]);
                    firstHand.Remove(firstHand[0]);
                }

            }

            if (firstHand.Any())
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }
    }
}

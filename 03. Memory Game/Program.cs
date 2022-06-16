using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            int moves = 0;

            while (input != "end")
            {
                moves++;
                var numbers = input.Split();
                var firstIndex = int.Parse(numbers[0]);
                var secondIndex = int.Parse(numbers[1]);

                if (firstIndex == secondIndex ||
                    firstIndex < 0 || secondIndex < 0 ||
                    firstIndex > list.Count - 1 ||
                    secondIndex > list.Count - 1)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");

                    string stringnumToAdd = "-" + moves.ToString() + "a";

                    list.Insert(list.Count / 2, stringnumToAdd);
                    list.Insert(list.Count / 2, stringnumToAdd);
                }
                else if (list[firstIndex] == list[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[firstIndex]}!");

                    if (firstIndex>secondIndex)
                    {
                        list.RemoveAt(firstIndex);
                        list.RemoveAt(secondIndex);
                    }
                    else
                    {
                        list.RemoveAt(secondIndex);
                        list.RemoveAt(firstIndex);
                    }

                }
                else if (list[firstIndex] != list[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }
                if (!list.Any())
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                input = Console.ReadLine();
            }
            if (list.Any())
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}

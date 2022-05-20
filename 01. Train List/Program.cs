using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                var command = input.Split();

                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    wagons.Add(number);
                }
                else
                {
                    int passengers = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currWagon = wagons[i];
                        if (currWagon + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}

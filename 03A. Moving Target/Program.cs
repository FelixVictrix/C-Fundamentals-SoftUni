using System;
using System.Collections.Generic;
using System.Linq;

namespace _03A._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] action = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = action[0];
                int index = int.Parse(action[1]);

                if (command == "Shoot")
                {
                    if (index >= 0 && index <= list.Count - 1)
                    {
                        int power = int.Parse(action[2]);
                        list[index] -= power;
                        if (list[index] <= 0)
                        {
                            list.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    if (index >= 0 && index <= list.Count - 1)
                    {
                        int value = int.Parse(action[2]);

                        list.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(action[2]);
                    int startIndex = index - radius;
                    int endIndex = index + radius;

                    if (startIndex >= 0 && endIndex < list.Count && radius > 0)
                    {

                        int count = 0;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            count++;
                        }
                        list.RemoveRange(startIndex, count);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", list));
        }
    }
}

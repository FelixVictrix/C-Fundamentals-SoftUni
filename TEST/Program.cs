using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    internal class Program
    {
        static void Main()
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = splitCommand[0];

                if (action == "Shoot")
                {
                    int index = int.Parse(splitCommand[1]);
                    int power = int.Parse(splitCommand[2]);

                    if (!ValidateIndex(targets, index))
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.Remove(targets[index]);
                        }
                    }
                }

                if (action == "Add")
                {
                    int index = int.Parse(splitCommand[1]);
                    int value = int.Parse(splitCommand[2]);

                    if (!ValidateIndex(targets, index))
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else
                    {
                        targets.Insert(index, value);
                    }
                }

                if (action == "Strike")
                {
                    int index = int.Parse(splitCommand[1]);
                    int radius = int.Parse(splitCommand[2]);
                    int positiveRange = index + radius;
                    int negativeRange = index - radius;

                    if (index >= 0 && index < targets.Count && positiveRange >= 0 && positiveRange < targets.Count && negativeRange >= 0 && negativeRange < targets.Count)
                    {
                        int start = Math.Max(0, index - radius);
                        int end = Math.Min(targets.Count - 1, index + radius);

                        targets.RemoveRange(start, end);
                    }

                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
        static bool ValidateIndex(List<int> targets, int value) => value >= 0 && value < targets.Count;
    }
}

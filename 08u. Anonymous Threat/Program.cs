using System;
using System.Collections.Generic;

namespace _08u._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                var commandArgs = input.Split();
                var action = commandArgs[0];
                var startIndex = int.Parse(commandArgs[1]);
                var endIndex = int.Parse(commandArgs[2]);

                if (action == "merge")
                {
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (startIndex >= list.Count)
                    {
                        startIndex = list.Count - 1;
                    }

                    string merged = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (startIndex < 0 || startIndex >= list.Count)
                        {
                            continue;
                        }

                        merged += list[startIndex];
                        list.RemoveAt(startIndex);
                    }
                    list.Insert(startIndex, merged);
                }
                else if (action == "divide")
                {
                    int index = startIndex;
                    int partitions = endIndex;

                    string element = list[index];
                    list.RemoveAt(index);

                    int parts = element.Length / partitions;
                    List<string> dividedElements = new List<string>();

                    for (int i = 0; i <= partitions - 1; i++)
                    {
                        string currElement = element.Substring(parts * i, parts);
                        dividedElements.Add(currElement);
                    }

                    if (element.Length % 2 == 1)
                    {
                        string lastElement = element.Substring(parts * (partitions -1));
                        dividedElements.Add(lastElement);
                    }
                    list.InsertRange(index, dividedElements);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

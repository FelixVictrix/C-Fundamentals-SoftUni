using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfDistances = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            while (listOfDistances.Any())
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    listOfDistances[0] = listOfDistances[^1];
                }
                else if (index > listOfDistances.Count -1)
                {
                    listOfDistances.Add(listOfDistances[0]);
                    // listOfDistances[^1] = listOfDistances[0];
                }
                var elementToRemove = listOfDistances[index];
                listOfDistances.RemoveAt(index);
                sum += elementToRemove;

                for (int i = 0; i < listOfDistances.Count; i++)
                {
                    if (elementToRemove < listOfDistances[i])
                    {
                        listOfDistances[i] -= elementToRemove;
                    }
                    else if(elementToRemove >= listOfDistances[i])
                    {
                        listOfDistances[i] += elementToRemove;
                    }
                }

            }

            Console.WriteLine(sum);
        }
    }
}

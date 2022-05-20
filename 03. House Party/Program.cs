using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<string> listOfNames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = command[0];

                if (command.Length == 3)
                {
                    if (!listOfNames.Contains(name))
                    {
                        listOfNames.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }


                if (command.Length == 4)
                {
                    if (listOfNames.Contains(name))
                    {
                        listOfNames.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

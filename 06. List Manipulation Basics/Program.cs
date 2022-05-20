using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listOfInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();
                string action = command[0];
                int number = int.Parse(command[1]);

                switch (action)
                {
                    case "Add":
                        listOfInt.Add(number); break;
                    case "Remove":
                        listOfInt.Remove(number); break;
                    case "RemoveAt":
                        int index = number;
                        listOfInt.RemoveAt(index); break;
                    case "Insert":
                        index = int.Parse(command[2]);
                        listOfInt.Insert(index, number); break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfInt));
        }
    }
}

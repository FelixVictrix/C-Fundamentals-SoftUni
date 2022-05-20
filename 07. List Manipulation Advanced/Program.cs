using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            List<int> backUpList = new List<int>(listOfInt);
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();
                string action = command[0];


                switch (action)
                {
                    case "Add":
                        int number = int.Parse(command[1]);
                        listOfInt.Add(number);
                        break;
                    case "Remove":
                        int num = int.Parse(command[1]);
                        listOfInt.Remove(num);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(command[1]);
                        listOfInt.RemoveAt(index);
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);
                        listOfInt.Insert(index, number);
                        break;
                    case "Contains":
                        number = int.Parse(command[1]);
                        string isNumber = listOfInt.Contains(number)
                            ? "Yes"
                            : "No such number";
                        Console.WriteLine(isNumber);
                        break;
                    case "PrintEven":
                        listOfInt.Where(x => x % 2 == 0)
                            .ToList()
                            .ForEach(x => Console.Write(x + " "));
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        listOfInt.Where(x => x % 2 == 1)
                            .ToList()
                            .ForEach(x => Console.Write(x + " "));
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = listOfInt.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = command[1];
                        number = int.Parse(command[2]);
                        if (condition == "<")
                        {
                            listOfInt.Where(x => x < number)
                                .ToList()
                            .ForEach(x => Console.Write(x + " "));
                        }
                        else if (condition == ">")
                        {
                            listOfInt.Where(x => x > number)
                                .ToList()
                            .ForEach(x => Console.Write(x + " "));
                        }
                        else if (condition == "<=")
                        {
                            listOfInt.Where(x => x <= number)
                                .ToList()
                            .ForEach(x => Console.Write(x + " "));
                        }
                        else if (condition == ">=")
                        {
                            listOfInt.Where(x => x >= number)
                                .ToList()
                            .ForEach(x => Console.Write(x + " "));
                        }
                        Console.WriteLine();
                        break;

                }

                input = Console.ReadLine();
            }

            bool isEqual = backUpList.Count == listOfInt.Count && backUpList.SequenceEqual(listOfInt);
            if (!isEqual)
            {
                Console.WriteLine(string.Join(" ", listOfInt));
            }
            
        }
    }
}

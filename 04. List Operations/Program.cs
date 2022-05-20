using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();
                string action = command[0];

                if (action == "Add")
                {
                    int number = int.Parse(command[1]);
                    list.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (IsVAlidIndex(index, list.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(index, number);
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (IsVAlidIndex(index, list.Count))
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        list.RemoveAt(index);
                    }

                }
                else if (action == "Shift")
                {
                    string direction = command[1];
                    int count = int.Parse(command[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int first = list[0];
                            for (int j = 0; j < list.Count - 1; j++)
                            {
                                list[j] = list[j + 1];
                            }
                            list[list.Count - 1] = first;
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int last = list[list.Count - 1];
                            list.RemoveAt(list.Count - 1);
                            list.Insert(0, last);
                        }

                        //for (int i = 0; i < count; i++)
                        //{
                        //    int last = list[list.Count - 1];
                        //    for (int j = list.Count - 1; j > 0; j--)
                        //    {
                        //        list[j] = list[j - 1];
                        //    }
                        //    list[0] = last;
                        //}
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }

        static bool IsVAlidIndex(int index, int count)
        {
            return index > count || index < 0;
        }
    }
}

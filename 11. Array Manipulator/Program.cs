using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] curr = input.Split();
                string command = curr[0];

                if (command == "exchange")
                {
                    int index = int.Parse(curr[1]);
                    if (index <= array.Length)
                    {
                        Exchange(index, array);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "max")
                {
                    string type = curr[1];
                    MaxElement(type, array);
                }
                else if (command == "min")
                {
                    string type = curr[1];
                    MinElement(type, array);
                }
                else if (command == "first")
                {
                    var countOfElements = int.Parse(curr[1]);
                    var type = curr[2];

                    if (countOfElements > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }
                    FirstCount(countOfElements, type, array);
                }

                input = Console.ReadLine();
            }

        }

        static void FirstCount(int countOfElements, string type, int[] array)
        {
            if (type == "even")
            {
                int count = 0;
                foreach (var even in array)
                {
                    if (even % 2 == 0)
                    {
                        count++;
                        //Console.Write($"[");
                        Console.Write(string.Join(", ", even));
                        //Console.Write($"]");
                    }

                    if (count == 2)
                    {
                        break;
                    }
                }
            }
        }

        static void MinElement(string type, int[] array)
        {
            if (type == "even" &&
                array.Any(x => x % 2 == 0))
            {
                int minEven = array.Where(x => x % 2 == 0).Min();
                int index = Array.IndexOf(array, minEven);
                Console.WriteLine(index);

            }
            else if (type == "odd"
                     && array.Any(x => x % 2 == 1))
            {
                int minOdd = array.Where(x => x % 2 == 1).Min();
                int index = Array.IndexOf(array, minOdd);
                Console.WriteLine(index);

            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void MaxElement(string type, int[] array)
        {

            if (type == "even" &&
                array.Any(x => x % 2 == 0))
            {
                int maxEven = array.Where(x => x % 2 == 0).Max();
                int index = Array.IndexOf(array, maxEven);
                Console.WriteLine(index);
            }
            else if (type == "odd" &&
                     array.Any(x => x % 2 == 1))
            {
                int maxOdd = array.Where(x => x % 2 == 1).Max();
                int index = Array.IndexOf(array, maxOdd);
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }

        static void Exchange(int index, int[] array)
        {
            for (int i = 0; i <= index; i++)
            {
                int first = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = first;
            }


        }
    }
}

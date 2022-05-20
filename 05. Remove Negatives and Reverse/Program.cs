using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x > 0)
                .Reverse()
                .ToList();

            //listOfInt = listOfInt.Where(x => x > 0).ToList();

            string result = listOfInt.Any()
                ? string.Join(" ", listOfInt)
                : "empty";

            Console.WriteLine(result);
        }
    }
}

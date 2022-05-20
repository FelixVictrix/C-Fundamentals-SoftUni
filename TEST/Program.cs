using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST
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
            listOfInt.Add(3);

            bool isEqual =backUpList.Count==listOfInt.Count && backUpList.SequenceEqual(listOfInt);
            if (!isEqual)
            {
                Console.WriteLine(string.Join(" ", listOfInt));
            }
        }
    }
}

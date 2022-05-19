using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> list = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                var first = list[i];
                var second = list[i + 1];

                if (first == second)
                {
                    var sum = first + second;
                    list.RemoveAt(i + 1);
                    list[i] = sum;
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

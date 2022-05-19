using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
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
                var last = list[list.Count - 1];
                var sum = first + last;
                list[i] = sum;
                list.RemoveAt(list.Count - 1);
            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}

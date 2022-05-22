using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<string> finel = new List<string>();

            foreach (var subArr in list)
            {
                var array = subArr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var s in array)
                {
                    finel.Add(s);
                }

            }


            Console.WriteLine(string.Join(" ", finel));
        }
    }
}
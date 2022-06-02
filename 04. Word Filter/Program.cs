using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split();

            array = array.Where(a => a.Length % 2 == 0).ToArray();
            Console.WriteLine(string.Join("\n", array));
        }
    }
}

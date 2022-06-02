using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>()
            {
                1,2,3,4,5
            };

            var res = list.Select(x => $"({x.ToString()})").ToList();

            Console.WriteLine(string.Join(":", res));

            string[] a = { "abc", "def" };
            var b = a.Select(a => a + "z");
            Console.WriteLine(string.Join(", ", b));
        }
    }
}

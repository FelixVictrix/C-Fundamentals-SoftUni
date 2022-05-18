using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var d in array)
            {
                var value = d;
                if (value == 0)
                {
                    value = 0;
                }
                var result = (int)Math.Round(value , MidpointRounding.AwayFromZero);
                Console.WriteLine($"{value} => {result}");

            }
        }
    }
}

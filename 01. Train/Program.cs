using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                array[i] = input;
            }
            
            Console.WriteLine(string.Join(" ",array));
            Console.WriteLine(array.Sum());
        }
    }
}

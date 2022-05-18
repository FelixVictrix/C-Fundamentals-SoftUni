using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var first = array[0];
                var current = new string[array.Length];
                for (int j = 0; j < current.Length - 1; j++)
                {
                    current[j] = array[j + 1];
                }
                current[^1] = first;
                array = current;
            }

            Console.WriteLine(string.Join(" ",array));
        }
    }
}

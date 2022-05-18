using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var array1 = new int[lines];
            var array2 = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    array1[i] = input[0];
                    array2[i] = input[1];
                }
                else
                {
                    array1[i] = input[1];
                    array2[i] = input[0];
                }
            }

            Console.Write(string.Join(" ",array1));
            Console.WriteLine();
            Console.Write(string.Join(" ",array2));
        }
    }
}

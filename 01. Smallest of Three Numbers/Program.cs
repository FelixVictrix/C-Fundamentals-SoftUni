using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                var input = Console.ReadLine();
                array[i] = int.Parse(input);
            }

            MinValue(array);

        }

        static void MinValue(int[] array)
        {
            var a = array.Min(x => x);
            Console.WriteLine(a);
        }
    }
}
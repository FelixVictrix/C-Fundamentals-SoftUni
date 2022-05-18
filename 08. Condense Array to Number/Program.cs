using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sum = 0;

            while (array.Length > 1)
            {

                int[] condense = new int[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    condense[i] = array[i] + array[i + 1];
                }
                array = condense;
            }

            Console.WriteLine(string.Join("", array));
        }
    }
}

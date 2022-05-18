using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new string[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine();
            }

            array = array.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", array));
        }
    }
}

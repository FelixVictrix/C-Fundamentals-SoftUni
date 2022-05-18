using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine()
                .Split().Reverse();
            Console.Write(string.Join(" ", array));

        }
    }
}

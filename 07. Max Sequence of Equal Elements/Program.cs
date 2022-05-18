using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var maxCount = 1;
            var maxValue = 0;
            var count = 1;

            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] == array[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count >= maxCount)
                {
                    maxCount = count;
                    maxValue = array[i];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxValue + " ");
            }
        }
    }
}

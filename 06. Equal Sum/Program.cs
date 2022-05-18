using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (array.Length == 2)
            {
                Console.WriteLine("no");
                return;
            }

            if (array.Sum() == 1)
            {
                Console.WriteLine("0");
                return;
            }
            else
            {
                int max = 0;
                int index = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        index = i;
                    }
                }

                int leftSum = 0;
                int rightSum = 0;

                for (int i = 0; i < index; i++)
                {
                    leftSum += array[i];
                }

                for (int i = array.Length - 1; i > index; i--)
                {
                    rightSum += array[i];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }

            

        }
    }
}

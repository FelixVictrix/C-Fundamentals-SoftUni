using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                var firstNum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    var secondNum = arr[j];
                    var currentSum = firstNum + secondNum;

                    if (number == currentSum)
                    {
                        Console.WriteLine($"{firstNum} {secondNum}");
                        break;
                    }
                }
            }
        }
    }
}

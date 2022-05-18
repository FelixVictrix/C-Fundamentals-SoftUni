using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Factorial(first, second);

        }

        static void Factorial(int first, int second)
        {
            double firstSum = 1;

            for (int i = 1; i <= first; i++)
            {
                firstSum *= i;
            }

            double secondSum = 1;

            for (int j = 1; j <= second; j++)
            {
                secondSum *= j;
            }

            double result = firstSum / secondSum;
            Console.WriteLine($"{result:f2}");
        }
    }
}

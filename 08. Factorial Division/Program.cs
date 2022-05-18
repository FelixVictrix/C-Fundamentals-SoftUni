using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());

            if (first >= 0 && second >= 0)
            {
                if (first == 0)
                {
                    first = 1;
                }

                if (second == 0)
                {
                    second = 1;
                }
                Factorial(first, second);
            }
        }

        static void Factorial(BigInteger first, BigInteger second)
        {
            BigInteger firstSum = 1;

            for (BigInteger i = 1; i <= first; i++)
            {
                firstSum *= i;
            }

            BigInteger secondSum = 1;

            for (BigInteger j = 1; j <= second; j++)
            {
                secondSum *= j;
            }

            BigInteger result = firstSum / secondSum;
            Console.WriteLine($"{result:f2}");
        }
    }
}

using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            string n = input.ToString();
            int[] array = new int[n.Length];

            for (int i = 0; i < n.Length; i++)
            {
                string a =  n[i].ToString();
                array[i] = int.Parse(a);
            }


            var evenSum = GetSumOfEvenDigits(array);
            var oddSum = GetSumOfOddDigits(array);

            GetMultipleOfEvenAndOdds(evenSum, oddSum);
        }

        static void GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            var sum = evenSum * oddSum;
            Console.WriteLine(sum);
        }

        static int GetSumOfEvenDigits(int[] array)
        {
            var evenSum = array.Where(x => x % 2 == 0).ToArray();
            return evenSum.Sum();
        }
        static int GetSumOfOddDigits(int[] array)
        {
            var oddSum = array.Where(x => x % 2 == 1).ToArray();
            return oddSum.Sum();
        }
    }
}


using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();

            Console.WriteLine(Multiply(input));
        }

        static int Multiply(string[] input)
        {
            string firstString = input[0];
            string secondString = input[1];
            int sum = 0;

            if (firstString.Length <= secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }
                secondString = secondString.Substring(firstString.Length);
                for (int j = 0; j < secondString.Length; j++)
                {
                    sum += secondString[j];
                }

            }
            else
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }
                firstString = firstString.Substring(secondString.Length);
                for (int j = 0; j < firstString.Length; j++)
                {
                    sum += firstString[j];
                }
            }

            return sum;
        }
    }
}

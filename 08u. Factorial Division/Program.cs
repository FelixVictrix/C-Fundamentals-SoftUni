using System;

namespace _08u._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstSum = GetFactorial(firstNum);
            double secondSum = GetFactorial(secondNum);
            double result = firstSum/secondSum;
            Console.WriteLine($"{result:f2}");
        }

        static double GetFactorial(int firstNum)
        {
            double result = 1;
            while (firstNum != 1)
            {
                result = result * firstNum;
                firstNum -= 1;
            }

            return result;
        }
    }
}

using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = int.Parse(Console.ReadLine());

            IntegerIs(input);

        }

        static void IntegerIs(int input)
        {
            if (input > 0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            else if (input<0)
            {
                Console.WriteLine($"The number {input} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {input} is zero.");
            }

        }
    }
}

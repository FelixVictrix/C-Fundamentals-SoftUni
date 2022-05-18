using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = Sum(first, second);
            int subtract = Subtract(third, sum);
            Console.WriteLine(subtract);
        }

        static int Subtract(int third, int sum)
        {
            int subtract = sum - third;
            return subtract;
        }

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
    }
}

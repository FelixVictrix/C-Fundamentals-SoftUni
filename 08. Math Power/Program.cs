using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
           double number = double.Parse(Console.ReadLine());
           double power = double.Parse(Console.ReadLine());

           
           Console.WriteLine(NumberPowerOf(number, power));
           
        }

        static double NumberPowerOf(double number, double power)
        {
           double result = Math.Pow(number,power);
           return result;
        }
    }
}

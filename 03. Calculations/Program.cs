using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Calculation(command, x, y);

        }

        static void Calculation(string command, int x, int y)
        {
            switch (command)
            {
                case "add":
                    var sum = x + y;
                    Console.WriteLine(sum);
                    break;
                case "multiply":
                    var multiply = x * y;
                    Console.WriteLine(multiply);
                    break;
                case "subtract":
                    var subtract = x - y;
                    Console.WriteLine(subtract); break;
                case "divide":
                    var divide = x / y;
                    Console.WriteLine(divide); break;

            }
        }
    }
}

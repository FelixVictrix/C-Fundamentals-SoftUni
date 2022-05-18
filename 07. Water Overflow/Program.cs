using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int tank = 0;

            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input <= tankCapacity)
                {
                    tankCapacity -= input;
                    tank+=input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(tank);
        }
    }
}

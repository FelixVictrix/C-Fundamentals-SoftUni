using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int courses = 0;

            for (int i = 0; i < n; i += p)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}

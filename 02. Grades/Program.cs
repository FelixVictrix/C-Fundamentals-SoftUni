using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            var grades = double.Parse(Console.ReadLine());

            RateGrades(grades);

        }

        static void RateGrades(double grades)
        {
            if (grades >= 2.00 && grades < 3.00)
            {
                Console.WriteLine("Fail");
            }
            else if (grades >= 3.00 && grades < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (grades >= 3.50 && grades < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (grades >= 4.50 && grades < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grades >= 5.50 && grades <= 6.00)
            {
                Console.WriteLine("Excellent");
            }

        }
    }
}

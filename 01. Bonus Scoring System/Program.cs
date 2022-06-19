using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfStudents = int.Parse(Console.ReadLine());
            int numOfLectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            double maxLecture = 0;

            for (int i = 0; i < numOfStudents; i++)
            {

                int attendance = int.Parse(Console.ReadLine());
                double totalBonus = (attendance * 1.0 / numOfLectures )* (5 + bonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxLecture = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.\nThe student has attended {maxLecture} lectures.");
        }
    }
}

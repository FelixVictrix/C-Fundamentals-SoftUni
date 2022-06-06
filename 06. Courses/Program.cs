using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> regiter = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] info = input.Split(" : ",StringSplitOptions.RemoveEmptyEntries);
                string course = info[0];
                string student = info[1];

                if (!regiter.ContainsKey(course))
                {
                    regiter.Add(course, new List<string>());
                }
                regiter[course].Add(student);
                input = Console.ReadLine();
            }
            foreach (var course in regiter.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}

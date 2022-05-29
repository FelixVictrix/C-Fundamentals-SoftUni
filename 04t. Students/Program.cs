using System;
using System.Collections.Generic;
using System.Linq;

namespace _04t._Students
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfStudents = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                students.Add(new Students(firstName, lastName, grade));
            }

            students = students.OrderByDescending(s => s.Grade).ToList();

            foreach (Students student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentInfo = input.Split();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string hometown = studentInfo[3];
 
                Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (student == null)
                {
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = hometown
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = hometown;

                }

                input = Console.ReadLine();
            }

            string townName = Console.ReadLine();

            foreach (var student in students.Where(x => x.HomeTown == townName))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
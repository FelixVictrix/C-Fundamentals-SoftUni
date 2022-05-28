using System;
using System.Collections.Generic;
using System.Linq;

namespace _05u._Students_2._0
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

                if (IsStudentExist(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = hometown;
                    
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = hometown
                    };
                    students.Add(student);
                }
                input = Console.ReadLine();
            }
            string townName = Console.ReadLine();

            foreach (var student in students.Where(x => x.HomeTown == townName))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        static bool IsStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
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

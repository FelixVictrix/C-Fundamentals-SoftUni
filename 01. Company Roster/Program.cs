using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {

                string[] employeeInfo = Console.ReadLine().Split();
                string name = employeeInfo[0];
                decimal salary = decimal.Parse(employeeInfo[1]);
                string department = employeeInfo[2];

                employees.Add(new Employee(name, salary, department));

            }

            decimal maxAverageSalary = 0;
            string maxDep = null;

            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    decimal averageSalary = 0;
                    if (employees[i].Salary <= 0 || employees[j].Salary <= 0)
                    {
                        continue;
                    }
                    if (employees[i].Department == employees[j].Department)
                    {
                        averageSalary = (employees[i].Salary + employees[j].Salary) / 2;

                    }
                    if (maxAverageSalary < averageSalary && maxDep != employees[i].Department)
                    {
                        maxAverageSalary = averageSalary;
                        maxDep = employees[i].Department;
                    }
                    else if (maxAverageSalary < averageSalary && maxDep == employees[i].Department)
                    {
                        maxAverageSalary += averageSalary;
                    }
                }
            }
            if (maxAverageSalary > 0)
            {
                Console.WriteLine($"Highest Average Salary: {maxDep}");
                employees = employees.Where(x => x.Department == maxDep).OrderByDescending(x => x.Salary).ToList();
                foreach (var item in employees)
                {
                    decimal salary = item.Salary;
                    Console.WriteLine($"{item.Name} {salary:f2}");
                }
            }
            else
            {
                maxAverageSalary = employees.Max(x => x.Salary);
                foreach (var item in employees.Where(x => x.Salary == maxAverageSalary))
                {
                    Console.WriteLine($"Highest Average Salary: {item.Department}");
                    Console.WriteLine($"{item.Name} {item.Salary:f2}");
                }

            }
        }
    }
    class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }


    }

}

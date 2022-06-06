using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,List<string>> companyList = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] employeeInfo = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = employeeInfo[0];
                string employeeId = employeeInfo[1];

                if (!companyList.ContainsKey(companyName))
                {
                    companyList.Add(companyName, new List<string>());
                }
                if (!companyList[companyName].Contains(employeeId))
                {
                    companyList[companyName].Add(employeeId);
                }
                input = Console.ReadLine();
            }
            foreach (var company in companyList.OrderBy(x=> x.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}

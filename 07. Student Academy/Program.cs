using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsInfo.ContainsKey(name))
                {
                    studentsInfo.Add(name, new List<double>());
                }
                studentsInfo[name].Add(grade);
            }
            foreach (var kvp in studentsInfo)
            {
                double aver = kvp.Value.Sum() / kvp.Value.Count;
                kvp.Value.RemoveRange(0, kvp.Value.Count);
                if (aver >= 4.50)
                {
                    kvp.Value.Add(aver);
                }
                 
            }
            foreach (var kvp in studentsInfo.OrderByDescending(x=> x.Key).ThenBy(x=> x.Value))
            {
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"{kvp.Key}-> {item:f2}");
                }
            }

        }
    }
}

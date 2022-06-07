using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<int>> results = new Dictionary<string, List<int>>();
            Dictionary<string, int> course = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {

                string[] userInfo = input.Split("-");
                string username = userInfo[0];
                string language = userInfo[1];

                if (language != "banned")
                {
                    int points = int.Parse(userInfo[2]);

                    if (!results.ContainsKey(username))
                    {
                        results.Add(username, new List<int>());
                    }
                    results[username].Add(points);

                    if (!course.ContainsKey(language))
                    {
                        course.Add(language, 0);
                    }
                    course[language]++;
                }
                else
                {
                    results.Remove(username);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var item in results.OrderByDescending(x => x.Value.Max()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {string.Join(" | ", item.Value.Max())}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in course.OrderByDescending(x=> x.Value).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"{item.Key} – {item.Value}");
            }
        }
    }
}

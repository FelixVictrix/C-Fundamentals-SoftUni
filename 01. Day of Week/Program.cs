using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var weekDays = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(weekDays[day - 1]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            //var people = new[]
            //{
            //    ( Name : "Patty", Age : 25, isMale : false ),
            //    ( Name : "Kenny", Age : 43, isMale : true ),
            //    ( Name : "Kate", Age : 37, isMale : false )
            //};

            //var res = people.Where(p => p.Name.StartsWith("K")).Select(p => p);
            //res = people.Where(p => p.Age >= 40).Select(p => p);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Name);
            //}

            string[] words = { "one", "two", "three" };

            var result = words.Select((w, i) => new { Index = i, Value = w }).Where(w => w.Value.Length == 3).ToList();

            Debug.WriteLine("Prints index for words that have a string length of 3:");
            foreach (var word in result)
                Debug.WriteLine(word.Index.ToString());

        }
    }
}

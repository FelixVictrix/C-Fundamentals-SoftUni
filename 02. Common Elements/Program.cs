using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split();
            var secondArray = Console.ReadLine().Split();

            var equal = secondArray.Intersect(firstArray).ToArray();
            Console.WriteLine(string.Join(" ",equal));

            //foreach (var s in secondArray)
            //{
            //    //var equal = firstArray.Where(x => x == s).Select(x=> x).ToArray();
            //    //Console.Write(string.Join(" ",equal));

            //    foreach (var s1 in firstArray)
            //    {
            //        if (s ==s1)
            //        {
            //            Console.Write(s1 + " ");
            //        }
            //    }
            //}
        }
    }
}

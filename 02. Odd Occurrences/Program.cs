using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string[] array = Console.ReadLine().ToLower().Split();

            for (int i = 0; i < array.Length; i++)
            {
                string curr = array[i];
                if (!dic.ContainsKey(curr))
                {
                    dic.Add(curr, 0);
                }
                dic[curr]++;
            }

            string[] a = dic.Where((x, KeyValuePair) => x.Value % 2 == 1).Select(x => x.Key).ToArray();
            
            Console.WriteLine(string.Join(" ", a));

            //foreach (var item in dic)
            //{
            //    if (item.Value % 2 == 1)
            //    {
            //        Console.Write(item.Key + " ");
            //    }
            //}

        }
    }
}

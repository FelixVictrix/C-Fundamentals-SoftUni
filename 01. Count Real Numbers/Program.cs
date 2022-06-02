using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int curr = array[i];
                if (!dic.ContainsKey(curr))
                {
                    dic.Add(curr, 0);
                }
                dic[curr] ++;
            }
            foreach (var kv in dic)
            {
                Console.WriteLine($"{kv.Key} -> {kv.Value}");
            }
        }
    }
}

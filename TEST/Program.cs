using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int  count = int.Parse(Console.ReadLine());

            //for (int i = 0; i < count; i++)
            //{
            //    int last = list[list.Count-1];
            //    list.RemoveAt(list.Count - 1);
            //    list.Insert(0, last);
                
            //    //for (int j = 0; j < list.Count - 1; j++)
            //    //{
            //    //    list.Insert()
            //    //}
            //    // list[list.Count - 1] = first;
            //}
            for (int i = 0; i < count; i++)
            {
                int last = list[list.Count - 1];
                for (int j = list.Count - 1; j > 0; j--)
                {
                    list[j] = list[j - 1];
                }
                list[0] = last;
            }

        }
    }
}

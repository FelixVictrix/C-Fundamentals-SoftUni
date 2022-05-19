using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> secondList = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> groupList = new List<double>();

            Merging(firstList,secondList, groupList);

            Console.WriteLine(string.Join(" ", groupList));
        }

       static void Merging(List<double> firstList, List<double> secondList, List<double> groupList)
        {
            if (firstList.Count > secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    groupList.Add(firstList[i]);
                    firstList.RemoveAt(i);
                    groupList.Add(secondList[i]);
                    secondList.RemoveAt(i);
                    i = -1;
                }
                groupList.AddRange(firstList);
            }
            else
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    groupList.Add(firstList[i]);
                    firstList.RemoveAt(i);
                    groupList.Add(secondList[i]);
                    secondList.RemoveAt(i);
                    i = -1;
                }
                groupList.AddRange(secondList);
            }
           
        }
    }
}

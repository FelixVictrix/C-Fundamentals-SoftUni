using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> firstList = new List<string>(Console.ReadLine().Split());
            List<string> secondList = new List<string>(Console.ReadLine().Split());

            List<string> mergedList = new List<string>();


            int first = 0;
            int second = 0;

            if (firstList.Count > secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    mergedList.Add(firstList[i]);
                    mergedList.Add(secondList[secondList.Count - 1 - i]);
                }

                firstList.RemoveRange(0, secondList.Count);
                first = int.Parse(firstList[0]);
                second = int.Parse(firstList[firstList.Count - 1]);
            }
            else if (secondList.Count > firstList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    mergedList.Add(firstList[i]);
                    mergedList.Add(secondList[secondList.Count - 1 - i]);
                }
                secondList.RemoveRange(secondList.Count - firstList.Count, firstList.Count);
                first = int.Parse(secondList[0]);
                second = int.Parse(secondList[secondList.Count - 1]);
            }

            mergedList = mergedList.OrderBy(x=> x).ToList();

            if (first > second)
            {
                for (int i = 0; i < mergedList.Count; i++)
                {
                    int currNum = int.Parse(mergedList[i]);
                    bool isTrue = currNum > second && currNum < first;
                    if (isTrue)
                    {
                        Console.Write(currNum + " ");
                    }
                }
            }
            else if (second > first)
            {
                for (int i = 0; i < mergedList.Count; i++)
                {
                    int currNum = int.Parse(mergedList[i]);
                    bool isTrue = currNum > first && currNum < second;
                    if (isTrue)
                    {
                        Console.Write(currNum + " ");
                    }
                }
            }

        }

    }
}

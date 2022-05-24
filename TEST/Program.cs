using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> firstList = new List<string>(Console.ReadLine().Split());
            List<string> secondList = new List<string>(Console.ReadLine().Split().Reverse());

            List<string> mergedList = new List<string>();

            int first = 0;
            int second = 0;
            bool isBigger = firstList.Count > secondList.Count;
            Merge(firstList, secondList);

            if (isBigger)
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
            else if (!isBigger)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    mergedList.Add(firstList[i]);
                    mergedList.Add(secondList[secondList.Count - 1 - i]);
                }
                secondList.RemoveRange(0, firstList.Count);
                first = int.Parse(secondList[0]);
                second = int.Parse(secondList[secondList.Count - 1]);
            }

        }

        private static void Merge(List<string> firstList, List<string> secondList)
        {
            throw new NotImplementedException();
        }
    }
}

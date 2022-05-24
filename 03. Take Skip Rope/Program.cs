using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            List<char> chrList = text.ToList();

            List<int> numList = new List<int>();
            List<string> nonNum = new List<string>();

            int num; string letter;

            for (int i = 0; i < chrList.Count; i++)
            {
                string curr = chrList[i].ToString();

                if (int.TryParse(curr, out num))
                {
                    numList.Add(num);
                }
                else
                {
                    nonNum.Add(curr);
                }
            }

            string message = string.Empty;

            for (int j = 0; j < numList.Count; j += 2)
            {
                int take = numList[j];
                int skip = numList[j + 1];

                
            }
        }
    }
}

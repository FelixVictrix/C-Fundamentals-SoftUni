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

            int num;

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

            //string message = string.Empty;
            List<string> message = new List<string>();

            for (int j = 0; j < numList.Count; j += 2)
            {
                int take = numList[j];
                int skip = numList[j + 1];

                if (take > nonNum.Count)
                {
                    take = nonNum.Count;
                }

                if (skip > nonNum.Count)
                {
                    skip = nonNum.Count;
                }

                if (skip == take)
                {
                    
                }
                for (int i = 0; i < take; i++)
                {
                    message.Add(nonNum[i]);
                }

                int count = take + skip;
                nonNum.RemoveRange(0, count);
            }

            Console.WriteLine();
            foreach (var VARIABLE in message)
            {
                Console.Write(VARIABLE);
            }

            Console.WriteLine();
        }
    }
}

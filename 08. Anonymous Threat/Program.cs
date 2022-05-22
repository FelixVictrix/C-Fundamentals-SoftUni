using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));

            List<string> copyList = new List<string>();
            List<string> newList = new List<string>();

            AddNewList(list, newList);

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                var command = input.Split();
                var action = command[0];

                if (action == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        string a = string.Concat(list[i], list[i + 1]);
                        copyList.Add(a);
                    }

                }
                else if (action == "divide")
                {
                    int index = int.Parse(command[1]);
                    string part = list[index];
                    int partitions = int.Parse(command[2]);

                    if (part.Length % 2 == 0)
                    {
                        for (int i = 0; i < part.Length; i++)
                        {
                            string a = string.Concat(list[i], list[i + 1]);
                            copyList.Add(a);
                        }
                    }
                    

                }



                input = Console.ReadLine();
            }



            Console.WriteLine(string.Join("", newList));
        }

        static void AddNewList(List<string> list, List<string> newList)
        {
            foreach (var str in list)
            {
                string currArr = str;

                for (int i = 0; i < currArr.Length; i++)
                {
                    char curr = char.Parse(currArr[i].ToString());
                    newList.Add(curr.ToString());
                }
            }
        }
    }
}

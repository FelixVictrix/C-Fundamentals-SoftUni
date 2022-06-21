using System;
using System.Text;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] actionInfo = input
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = actionInfo[0];

                if (command == "Contains")
                {
                    string substring = actionInfo[1];
                    string isFound = key.Contains(substring)
                        ? $"{key} contains {substring}"
                        : "Substring not found!";
                    Console.WriteLine(isFound);
                }
                else if (command == "Flip")
                {
                    string flipCase = actionInfo[1];
                    int startIndex = int.Parse(actionInfo[2]);
                    int endIndex = int.Parse(actionInfo[3]);
                    int count = endIndex - startIndex;
                    string change = key.Substring(startIndex,count);

                    if (flipCase == "Upper")
                    {
                        key = key.Replace(change, change.ToUpper());
                    }
                    else
                    {
                        key = key.Replace(change, change.ToLower());
                    }
                    Console.WriteLine(key);
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(actionInfo[1]);
                    int endIndex = int.Parse(actionInfo[2]);
                    int count = endIndex - startIndex;
                    //int toSlice = key.Substring(startIndex, count).Length - 1;

                    key = key.Remove(startIndex, count);
                    Console.WriteLine(key);
                }




                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}

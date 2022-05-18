using System;
using System.Linq;

namespace _06u._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isFound = false
                ;
            for (int curr = 0; curr < arr.Length; curr++)
            {
                var rightSum = 0;

                for (int i = curr + 1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }

                var leftSum = 0;

                for (int j = curr - 1; j >= 0; j--)
                {
                    leftSum += arr[j];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(curr);
                    isFound =true;
                    break;
                }

            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}

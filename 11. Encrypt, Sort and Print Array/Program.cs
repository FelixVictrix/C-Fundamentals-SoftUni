using System;
using System.Linq;

namespace _11._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var sums = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var currSum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    int c = input[j];
                    switch (c)
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'O':
                        case 'o':
                        case 'u':
                        case 'U':
                            currSum += ((int)c) * input.Length;
                            break;
                        default:
                            currSum += ((int)c) / input.Length;
                            break;
                    }
                }
                sums[i] = currSum;
            }
            sums = sums.OrderBy(x => x).ToArray();
            foreach (var sum in sums)
            {
                Console.WriteLine(sum);
            }
        }
    }
}

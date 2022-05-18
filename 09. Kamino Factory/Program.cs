using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            var dnaLength = int.Parse(Console.ReadLine());
            var dNa = new int[dnaLength];

            var input = Console.ReadLine();
            var maxCount = 1;
            var maxArray = new int[dNa.Length];
            var currCount = 0;
            var seqCount = 0;
            var bestCount = 0;
            var index = int.MaxValue; ;
            var sum = 0;
            //var maxSum = 0;

            while (input != "Clone them!")
            {
                dNa = input
               .Split('!', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
                seqCount++;
                for (int i = 0; i < dNa.Length - 1; i++)
                {

                    if (dNa[i] == 1)
                    {
                        if (dNa[i] == dNa[i + 1])
                        {
                            currCount++;
                            sum++;
                        }
                        else
                        {
                            currCount = 0;
                        }

                        if (currCount > maxCount ||
                            (currCount == maxCount && i < index) ||
                            (currCount == maxCount && i < index && dNa.Sum() > maxArray.Sum()))

                        {
                            maxCount = currCount;
                            maxArray = dNa;
                            index = i;
                            bestCount = seqCount;
                        }
                    }
                }


                input = Console.ReadLine();
            }

            if (maxArray.Sum() > 0)
            {
                Console.WriteLine($"Best DNA sample {bestCount} with sum: {maxArray.Sum()}.");
                Console.WriteLine(string.Join(" ", maxArray));
            }
            //Console.WriteLine($"Best DNA sample {bestCount} with sum: {maxArray.Sum()}.");
            //Console.WriteLine(string.Join(" ", maxArray));
        }
    }
}

using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
      

            for (int i = 0; i < array.Length; i++)
            {
                var isBig = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        isBig=true;
                    }
                    else
                    {
                        isBig = false;
                        break;
                    }
                }

                if (isBig)
                {
                    Console.Write(array[i] + " ");
                }
                //if (max > 0)
                //{
                //    Console.Write(max + " ");
                //}

                //if (array[i] == array[array.Length - 1])
                //{
                //    Console.Write(array[i]);
                //}
            }

            //int[] array = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    bool isBigger = true;
            //    if (i < array.Length - 1)
            //    {
            //        for (int j = i + 1; j < array.Length; j++)
            //        {
            //            isBigger = false;
            //            if (array[i] > array[j])
            //            {
            //                isBigger = true;
            //            }
            //            else if (!isBigger)
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    if (isBigger)
            //    {
            //        Console.Write(array[i] + " ");
            //    }
            //}
        }
    }
}

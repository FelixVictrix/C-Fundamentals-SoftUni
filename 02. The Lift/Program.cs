using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {

            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> liftSpace = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxSpace = 4;
            int count = 0;

            if (peopleWaiting > 0)
            {
                for (int i = 0; i < liftSpace.Count; i++)
                {
                    count++;
                    for (int j = liftSpace[i]; j < maxSpace; j++)
                    {
                        liftSpace[i]++;
                        peopleWaiting--;
                        if (peopleWaiting <= 0 && liftSpace[i] < 4)
                        {
                            Console.WriteLine("The lift has empty spots!");
                            Console.WriteLine(string.Join(" ", liftSpace));
                            return;
                        }
                    }
                    if (liftSpace.All(p => p == 4) && peopleWaiting == 0)
                    {
                        Console.WriteLine(string.Join(" ", liftSpace));
                        break;
                    }
                }
                if (peopleWaiting > 0)
                {
                    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                    Console.WriteLine(string.Join(" ", liftSpace));
                }
                else
                {
                    Console.WriteLine(string.Join(" ", liftSpace));
                }
            }
        }
    }
}

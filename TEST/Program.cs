using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            int[] spots = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int max = 4;

            if (people > 0)
            {
                for (int i = 0; i < spots.Length; i++)
                {
                    int currSpot = spots[i];

                    if (currSpot == max)
                    {
                        continue;
                    }
                    if (max > people && people!=currSpot)
                    {
                        max = people;
                    
                        Console.WriteLine("The lift has empty spots!");
                    }
                    else
                    {
                        max = max-currSpot+people;
                    }
                    if (currSpot < 4)
                    {
                        spots[i] += max - currSpot;
                        people -= max - currSpot;
                    }
                    if (spots.All(p => p == 4) && people == 0)
                    {
                        break;
                    }
                }
            }
            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
           
            Console.WriteLine(string.Join(" ", spots));
        }
    }
}

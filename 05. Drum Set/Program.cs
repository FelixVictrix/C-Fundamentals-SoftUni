using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {

            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> usedSet = new List<int>(drumSet);


            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < usedSet.Count; i++)
                {
                    usedSet[i] -= hitPower;
                    int currDrum = usedSet[i];
                    bool isBroken = currDrum <= 0;

                    if (isBroken && savings >= drumSet[i] * 3)
                    {
                        usedSet[i] = drumSet[i];
                        savings -= drumSet[i] * 3;
                    }
                    else if (isBroken && savings < drumSet[i] * 3)
                    {
                        if (usedSet.Count - 1 == i)
                        {
                            usedSet.RemoveAt(i);
                            drumSet.RemoveAt(i);
                        }
                        else
                        {
                            usedSet.RemoveAt(i);
                            drumSet.RemoveAt(i);
                            i -= 1;
                        }

                    }
                }



                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", usedSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}

using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];
            int[] ladybugIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var t in ladybugIndex)
            {
                field[t] = 1;
            }

            string input = Console.ReadLine();

            while (input != "end")
            {
                bool isTure = true;

                while (isTure)
                {

                    var command = input.Split();
                    var startFly = int.Parse(command[0]);
                    var movement = command[1];
                    var flyLength = int.Parse(command[2]);
                    var startIndex = int.Parse(command[0]);

                    if (movement == "right" || (movement == "left" && flyLength < 0))
                    {
                        flyLength = Math.Abs(flyLength);

                        for (int i = startFly; i <= startFly + flyLength; i++)
                        {

                            if (flyLength <= field.Length)
                            {
                                if (startFly + 1 <= field.Length - 1)
                                {
                                    if (field[startFly + 1] != 1 && startFly + flyLength <= field.Length)
                                    {
                                        field[startIndex] = 0;
                                        field[startFly + 1] = 1;
                                        isTure = false;
                                    }
                                    else if (field[startFly + 1] == 1 && startFly + flyLength <= field.Length)
                                    {
                                        startFly++;
                                        isTure = true; ;
                                    }
                                }
                                else
                                {
                                    field[startIndex] = 0;
                                    isTure = false;
                                }

                            }
                        }
                    }
                    else if (movement == "left")
                    {
                        for (int i = startFly; i > startFly - flyLength; i--)
                        {
                            if (flyLength <= field.Length)
                            {
                                if (startFly - 1 <= field.Length - 1)
                                {
                                    if (field[startFly - 1] != 1 && startFly + flyLength <= field.Length)
                                    {
                                        field[startIndex] = 0;
                                        startIndex--;
                                        field[startFly - 1] = 1;
                                        isTure = false;
                                    }
                                    else if (field[startFly - 1] == 1 && startFly + flyLength <= field.Length)
                                    {
                                        startFly--;
                                        isTure = true; ;
                                    }
                                }
                                else
                                {
                                    field[startIndex] = 0;
                                    isTure = false;
                                }

                            }
                        }
                    }



                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}

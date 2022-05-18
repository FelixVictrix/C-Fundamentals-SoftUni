using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfBalls = int.Parse(Console.ReadLine());
            BigInteger maxBall = int.MinValue;
            int snow = 0;
            int time = 0;
            int quality = 0;

            if (numberOfBalls >= 0)
            {

                for (int i = 0; i < numberOfBalls; i++)
                {
                    int snowballSnow = int.Parse(Console.ReadLine());
                    int snowballTime = int.Parse(Console.ReadLine());
                    int snowballQuality = int.Parse(Console.ReadLine());
                    BigInteger snowballValue = 0;


                    if (snowballSnow >= 0 && snowballTime > 0 && snowballQuality >= 0)
                    {
                        snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                    }

                    if (snowballValue > maxBall)
                    {
                        maxBall = snowballValue;
                        snow = snowballSnow;
                        time = snowballTime;
                        quality = snowballQuality;
                    }

                }

            }

            Console.WriteLine($"{snow} : {time} = {maxBall} ({quality})");
        }
    }
}

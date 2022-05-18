using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {

            int pokePower = int.Parse(Console.ReadLine()); // poke power N
            int distance = int.Parse(Console.ReadLine()); // distance between poke targets M
            int exhaustionFactor = int.Parse(Console.ReadLine()); // exhaustionFactor Y

            int pokedCount = 0;
            int powerHalf = pokePower / 2;

            while (distance <= pokePower)
            {
                pokedCount++;
                pokePower -= distance;

                if (pokePower == powerHalf && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedCount);
        }
    }
}

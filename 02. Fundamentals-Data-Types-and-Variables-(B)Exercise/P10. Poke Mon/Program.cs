using System;

namespace P10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int targetDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double remainingPower = pokemonPower * 0.5d;
            int targetCount = 0;

            while (pokemonPower >= targetDistance)
            {
                pokemonPower -= targetDistance;
                targetCount++;
                if (remainingPower == pokemonPower && exhaustionFactor != 0)
                {
                    pokemonPower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokemonPower);
            Console.WriteLine(targetCount);
        }
    }
}
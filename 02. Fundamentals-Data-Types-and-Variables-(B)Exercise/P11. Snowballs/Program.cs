using System;
using System.Numerics;

namespace P11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;

            for (int i = 1; i <= snowballsCount; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger currentSnowballValue = BigInteger.Pow(snow / time, quality);

                if (currentSnowballValue > snowballValue)
                {
                    snowballSnow = snow;
                    snowballTime = time;
                    snowballQuality = quality;
                    snowballValue = currentSnowballValue;
                }
            }

            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
        }
    }
}
using System;

namespace P08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double kegVolume = 0;

            for (int i = 1; i <= inputCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double currentKegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (currentKegVolume > kegVolume)
                {
                    kegVolume = currentKegVolume;
                    biggestKeg = kegModel;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
using System;

namespace P07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            int waterTankCapacity = 255;
            int waterLitersInTank = 0;

            for (int i = 1; i <= inputCount; i++)
            {
                int waterPourQuan = int.Parse(Console.ReadLine());
                waterLitersInTank += waterPourQuan;

                if (waterLitersInTank > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterLitersInTank -= waterPourQuan;
                }
            }

            Console.WriteLine(waterLitersInTank);
        }
    }
}
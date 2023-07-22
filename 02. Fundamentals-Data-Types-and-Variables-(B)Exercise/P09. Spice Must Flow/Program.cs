using System;

namespace P09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalSpiceAmount = 0;
            int yieldDaysCount = 0;
            while (startingYield >= 100)
            {
                totalSpiceAmount += startingYield;
                startingYield -= 10;
                totalSpiceAmount -= 26;
                yieldDaysCount++;
            }

            totalSpiceAmount -= 26;
            if (totalSpiceAmount < 0)
            {
                totalSpiceAmount = 0;
            }
            Console.WriteLine(yieldDaysCount);
            Console.WriteLine(totalSpiceAmount);
        }
    }
}
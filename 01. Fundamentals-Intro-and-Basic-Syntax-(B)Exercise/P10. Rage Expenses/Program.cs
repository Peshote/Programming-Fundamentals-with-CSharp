using System;

namespace P10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short lostGamesCount = short.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine()); 
            float mousePrice = float.Parse(Console.ReadLine());
            float keybordPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            float rageExpenses = 0;
            
            for (short i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }

                if (i % 6 == 0)
                {
                    rageExpenses += keybordPrice;
                }

                if (i % 12 == 0)
                {
                    rageExpenses += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
using System;

namespace P09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double pricePerSaber = double.Parse(Console.ReadLine());
            double pricePerRobe = double.Parse(Console.ReadLine());
            double pricePerBelt = double.Parse(Console.ReadLine());
            
            double lightSabersCount = Math.Ceiling(studentsCount * 0.10);
            int freeBelts = studentsCount / 6;

            double sabersPrice = (studentsCount + lightSabersCount) * pricePerSaber;
            double robesPrice = studentsCount * pricePerRobe;
            double beltsPrice = (studentsCount - freeBelts) * pricePerBelt;
            double totalSum = sabersPrice + robesPrice + beltsPrice;

            if (totalSum <= moneyAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {totalSum - moneyAmount:F2}lv more.");
            }
        }
    }
}
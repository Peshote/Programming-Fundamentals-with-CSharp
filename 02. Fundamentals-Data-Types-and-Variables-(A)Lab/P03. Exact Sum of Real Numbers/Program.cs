using System;

namespace P03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            decimal numbersSum = 0m;

            for (int i = 1; i <= numbersCount; i++)
            {
                decimal inputNum = decimal.Parse(Console.ReadLine());
                numbersSum += inputNum;
            }
            Console.WriteLine(numbersSum);
        }
    }
}
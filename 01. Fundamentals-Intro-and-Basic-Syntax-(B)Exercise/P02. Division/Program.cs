using System;

namespace P02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividendNumber = int.Parse(Console.ReadLine());
            int divisorNumber = 0;
            if (dividendNumber % 2 == 0)
            {
                divisorNumber = 2;
            }
            if (dividendNumber % 3 == 0)
            {
                divisorNumber = 3;
            }
            if (dividendNumber % 6  == 0)
            {
                divisorNumber = 6;
            }
            if (dividendNumber % 7  == 0)
            {
                divisorNumber = 7;
            }
            if (dividendNumber % 10 == 0)
            {
                divisorNumber = 10;
            }
            else if (dividendNumber % 2 != 0 &&  dividendNumber % 3 != 0 && dividendNumber % 6 != 0 && dividendNumber % 7 !=0 && dividendNumber % 10 != 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }
            Console.WriteLine($"The number is divisible by {divisorNumber}");
        }
    }
}

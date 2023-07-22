using System;

namespace P04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 1; i <= inputCount; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                totalSum += inputChar;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
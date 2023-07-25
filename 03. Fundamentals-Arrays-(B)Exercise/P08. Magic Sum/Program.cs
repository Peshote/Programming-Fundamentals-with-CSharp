using System;
using System.Linq;

namespace P08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersArray.Length; i++)
            {
                for (int k = 0; k < numbersArray.Length; k++)
                {
                    if (k == i)
                    {
                        continue;
                    }
                    if (numbersArray[i] + numbersArray[k] == inputNumber && i < k)
                    {
                        Console.WriteLine($"{numbersArray[i]} {numbersArray[k]}");
                    }
                }
            }
        }
    }
}
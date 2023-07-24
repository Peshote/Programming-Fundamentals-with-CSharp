using System;
using System.Linq;

namespace P08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] condensedNumbers = new int[numbers.Length - 1];
            while (numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensedNumbers[i] = numbers[i] + numbers[i + 1];
                    if (i == condensedNumbers.Length - 1)
                    {
                        numbers = condensedNumbers;
                        condensedNumbers = new int[numbers.Length - 1];
                    }
                }
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
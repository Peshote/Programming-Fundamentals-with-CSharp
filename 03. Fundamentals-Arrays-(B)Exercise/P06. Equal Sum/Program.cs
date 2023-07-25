using System;
using System.Linq;

namespace P06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool noIndex = true;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbersArray[j];
                }

                for (int k = i + 1; k < numbersArray.Length; k++)
                {
                    rightSum += numbersArray[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    noIndex = false;
                }
            }

            if (noIndex)
            {
                Console.WriteLine("no");
            }
        }
    }
}
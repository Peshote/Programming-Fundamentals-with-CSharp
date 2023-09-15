using System;
using System.Linq;

namespace P04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] firstRow = new int[inputNumbers.Length / 2];
            int[] secondRow = new int[firstRow.Length];

            int[] firstRowLeft = new int[firstRow.Length / 2];
            int[] firstRowRight = new int[firstRow.Length / 2];                      

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (i < inputNumbers.Length / 4)
                {
                    firstRowLeft[i] = inputNumbers[i];
                }
                else if ( i > (inputNumbers.Length * 0.75) - 1)
                {
                    for (int j = 0; j < firstRowRight.Length; j++)
                    {
                        firstRowRight[j] = inputNumbers[i];
                        i++;
                    }
                }
                else
                {
                    secondRow[i - (inputNumbers.Length / 4)] = inputNumbers[i];
                }
            }

            Array.Reverse(firstRowLeft);
            Array.Reverse(firstRowRight);
            
            Array.Copy(firstRowLeft, firstRow, firstRowLeft.Length);
            Array.Copy(firstRowRight, 0, firstRow, firstRowLeft.Length, firstRowRight.Length);

            int[] sumResult = new int[inputNumbers.Length / 2];

            for(int i = 0; i < sumResult.Length; i++)
            {
                sumResult[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sumResult));
        }
    }
}
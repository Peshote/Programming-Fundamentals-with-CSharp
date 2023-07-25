using System;
using System.Linq;

namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string longestSequence = "";

            int startIndex = 0;
            int maxLength = 1;
            int currentStartIndex = 0;
            int currentLength = 1;

            for (int i = 1; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == numbersArray[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentStartIndex = i;
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = currentStartIndex;
                }
            }
            
            for (int i = startIndex; i < startIndex + maxLength; i++)
            {
                longestSequence += (numbersArray[i] + " ");
            }
            Console.WriteLine(longestSequence);
        }
    }
}
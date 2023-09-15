using System;

namespace P01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceCount = int.Parse(Console.ReadLine());

            string[] sequences = new string[sequenceCount];

            int[] encryptedSsequences = new int[sequenceCount];

            for (int i = 0; i < sequenceCount; i++)
            {
                sequences[i] = Console.ReadLine();

                string currentSequence = sequences[i];

                int currentSum = 0;

                for (int j = 0; j < currentSequence.Length; j++)
                {
                    char digit = currentSequence[j];
                    int value = digit;

                    if (digit == 'a' || digit == 'e' || digit == 'i' || digit == 'o' || digit == 'u' || digit == 'A' || digit == 'E' || digit == 'I' || digit == 'O' || digit == 'U')
                    {
                        currentSum += value * currentSequence.Length;
                    }
                    else
                    {
                        currentSum += value / currentSequence.Length;
                    }
                    encryptedSsequences[i] = currentSum;
                }
            }

            Array.Sort(encryptedSsequences);

            for (int i = 0;i < encryptedSsequences.Length; i++)
            {
                Console.WriteLine(encryptedSsequences[i]);
            }
        }
    }
}
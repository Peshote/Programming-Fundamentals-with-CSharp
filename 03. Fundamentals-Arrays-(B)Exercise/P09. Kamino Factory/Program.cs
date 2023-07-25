using System;
using System.Linq;


namespace P09._Kamino_Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            int[] bestSequence = null;
            int bestSequenceIndex = -1;
            int bestSequenceLength = 0;
            int bestSequenceStartIndex = dnaLength;
            int bestSequenceSum = 0;

            string input;
            int sequenceIndex = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] sequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceIndex++;

                int sequenceStartIndex = 0;
                int sequenceLength = 0;
                int currentSequenceStartIndex = 0;
                int currentSequenceLength = 0;
                int currentSequenceSum = 0;

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        currentSequenceLength++;
                        currentSequenceSum++;

                        if (currentSequenceLength > sequenceLength)
                        {
                            sequenceStartIndex = currentSequenceStartIndex;
                            sequenceLength = currentSequenceLength;
                        }
                        else if (currentSequenceLength == sequenceLength && currentSequenceStartIndex < sequenceStartIndex)
                        {
                            sequenceStartIndex = currentSequenceStartIndex;
                        }
                    }
                    else
                    {
                        currentSequenceStartIndex = i + 1;
                        currentSequenceLength = 0;
                    }
                }

                if (sequenceLength > bestSequenceLength)
                {
                    bestSequence = sequence;
                    bestSequenceIndex = sequenceIndex;
                    bestSequenceLength = sequenceLength;
                    bestSequenceStartIndex = sequenceStartIndex;
                    bestSequenceSum = currentSequenceSum;
                }
                else if (sequenceLength == bestSequenceLength && sequenceStartIndex < bestSequenceStartIndex)
                {
                    bestSequence = sequence;
                    bestSequenceIndex = sequenceIndex;
                    bestSequenceStartIndex = sequenceStartIndex;
                    bestSequenceSum = currentSequenceSum;
                }
                else if (sequenceLength == bestSequenceLength && sequenceStartIndex == bestSequenceStartIndex && currentSequenceSum > bestSequenceSum)
                {
                    bestSequence = sequence;
                    bestSequenceIndex = sequenceIndex;
                    bestSequenceSum = currentSequenceSum;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
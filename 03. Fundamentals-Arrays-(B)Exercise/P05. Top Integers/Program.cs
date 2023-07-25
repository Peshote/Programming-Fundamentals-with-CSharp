using System;
using System.Linq;

namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string output = "";

            for (int i = 0; i < numbersArray.Length; i++)
            {
                bool isGreater = true;
                for (int j = i + 1; j < numbersArray.Length; j++)
                {
                    if (numbersArray[i] <= numbersArray[j])
                    {
                        isGreater = false;
                        break;
                    }
                }
                if (isGreater)
                {
                    output += ($"{numbersArray[i]} ");
                }
            }
            Console.WriteLine(output);
        }
    }
}
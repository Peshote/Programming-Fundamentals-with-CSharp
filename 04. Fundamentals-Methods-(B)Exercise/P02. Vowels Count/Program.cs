using System;

namespace P02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            CountVowels(input);
        }
        static void CountVowels(string input)
        {
            int vowelCount = 0;

            foreach (char c in input)
            {                
                char lowerC = Char.ToLower(c);
                                
                if (lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);
        }
    }
}
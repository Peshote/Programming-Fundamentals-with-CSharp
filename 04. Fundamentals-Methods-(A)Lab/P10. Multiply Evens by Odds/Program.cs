using System;

namespace P10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        private static string input;
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum < 0)
            {
                inputNum = Math.Abs(inputNum);
            }

            string input = inputNum.ToString();

            Console.WriteLine(GetMultipleOfEvenAndOdds());
        }

        private static int GetMultipleOfEvenAndOdds()
        {
            int result = GetSumOfEvenDigits() * GetSumOfOddDigits();
            return result;
        }

        private static int GetSumOfEvenDigits()
        {
            int result = 0;

            foreach (char digitChar in input)
            {
                int digit = int.Parse(digitChar.ToString());
                if (digit % 2 == 0)
                {
                    result += digit;
                }                
            }
            
            return result;
        }

        private static int GetSumOfOddDigits()
        {
            int result = 0;

            foreach (char digitChar in input)
            {
                int digit = int.Parse(digitChar.ToString());
                if (digit % 2 != 0)
                {
                    result += digit;
                }                
            }

            return result;
        }
    }
}
using System;

namespace P10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopNumbers(n);
        }

        static void PrintTopNumbers(int n)
        {
            for (int number = 1; number <= n; number++)
            {
                if (IsTopNumber(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            int sumOfDigits = CalculateSumOfDigits(number);

            if (sumOfDigits % 8 != 0)
            {
                return false;
            }

            bool hasOddDigit = ContainsOddDigit(number);

            return hasOddDigit;
        }

        static int CalculateSumOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }

        static bool ContainsOddDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
using System;

namespace P09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                int number = int.Parse(input);
                bool isPalindrome = IsPalindrome(number);
                Console.WriteLine(isPalindrome);
            }
        }

        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int left = 0;
            int right = numberString.Length - 1;

            while (left < right)
            {
                if (numberString[left] != numberString[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
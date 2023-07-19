using System;

namespace P06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string numberString = inputNumber.ToString();
            int sum = 0;

            for (int i = 0; i < numberString.Length; i++)
            {
                int digit = int.Parse(numberString[i].ToString());
                int factorial = 1;

                for (int j = 2; j <= digit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }

            if (sum == inputNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
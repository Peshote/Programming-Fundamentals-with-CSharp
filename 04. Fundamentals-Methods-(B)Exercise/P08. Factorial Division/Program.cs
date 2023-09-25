using System;

namespace P08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double factorial1 = CalculateFactorial(number1);
            double factorial2 = CalculateFactorial(number2);

            double result = factorial1 / factorial2;

            Console.WriteLine($"{result:F2}");
        }

        static double CalculateFactorial(int number)
        {
            double factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
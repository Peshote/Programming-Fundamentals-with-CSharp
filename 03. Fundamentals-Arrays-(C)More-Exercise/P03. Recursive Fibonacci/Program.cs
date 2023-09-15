using System;
using System.Collections.Generic;

namespace P03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SolveMemoization(fibonacciNumber));
        }
        public static double SolveMemoization(int fibonacciNumber)
        {
            double result;
            if (memo.ContainsKey(fibonacciNumber))
            {
                result = memo[fibonacciNumber];
            }
            else
            {
                result = SolveMemoization(fibonacciNumber - 1) + SolveMemoization(fibonacciNumber - 2);
                memo[fibonacciNumber] = result;
            }
            return result;

        }

        static Dictionary<int, double> memo = new Dictionary<int, double>() { {1, 1}, {2, 1} };
    }
}
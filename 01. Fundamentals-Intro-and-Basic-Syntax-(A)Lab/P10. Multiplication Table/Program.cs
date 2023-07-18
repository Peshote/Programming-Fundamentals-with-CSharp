using System;

namespace P10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int multiplicationTimes = 1;
            int product = 0;

            while (multiplicationTimes <= 10)
            {
                product = theInteger * multiplicationTimes;
                Console.WriteLine($"{theInteger} X {multiplicationTimes} = {product}");
                multiplicationTimes++;
            }
        }
    }
}

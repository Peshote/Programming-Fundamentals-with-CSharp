using System;

namespace P10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int multiplicationTimes = int.Parse(Console.ReadLine());
            int product = 0;

            if (multiplicationTimes > 10)
            {
                product = theInteger * multiplicationTimes;
                Console.WriteLine($"{theInteger} X {multiplicationTimes} = {product}");
            }
            while (multiplicationTimes <= 10)
            {
                product = theInteger * multiplicationTimes;
                Console.WriteLine($"{theInteger} X {multiplicationTimes} = {product}");
                multiplicationTimes++;
            }            
        }
    }
}
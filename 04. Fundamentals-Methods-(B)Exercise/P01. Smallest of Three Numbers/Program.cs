using System;

namespace P01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            PrintSmallestNumber (num1, num2, num3);
        }
        static void PrintSmallestNumber(int num1, int num2, int num3)
        {
            int smallest = num1;

            if (num2 < smallest)
            {
                smallest = num2;
            }

            if (num3 < smallest)
            {
                smallest = num3;
            }

            Console.WriteLine(smallest);
        }
    }
}
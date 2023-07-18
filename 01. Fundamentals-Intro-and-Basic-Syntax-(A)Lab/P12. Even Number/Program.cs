using System;

namespace P12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");                
            }            
            while (number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                number = double.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
            }            
        }
    }
}
using System;

namespace P01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metersDistance = int.Parse(Console.ReadLine());
            double kilometersDistance = (double)metersDistance / 1000;

            Console.WriteLine($"{kilometersDistance:F2}");
        }
    }
}

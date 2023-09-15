using System;

namespace P08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            int powerNum = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(baseNum, powerNum));
        }

        private static double RaiseToPower(double baseNum, int powerNum)
        {
            double result = 0d;

            result = Math.Pow(baseNum, powerNum);

            return result;
        }
    }
}
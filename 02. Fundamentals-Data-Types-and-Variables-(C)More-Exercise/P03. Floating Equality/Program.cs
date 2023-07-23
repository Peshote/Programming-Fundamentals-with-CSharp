using System;

namespace P03._Floating_Equality
{
    internal class Program
    {
        public static bool CompareDoubles(double a, double b, double eps = 0.000001)
        {
            return Math.Abs(a - b) < eps;
        }
        static void Main(string[] args)
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());
           
            bool result = CompareDoubles(numA, numB);
            string output = result ? "True" : "False";
            output = char.ToUpper(output[0]) + output.Substring(1);

            Console.WriteLine(output);
        }
    }
}
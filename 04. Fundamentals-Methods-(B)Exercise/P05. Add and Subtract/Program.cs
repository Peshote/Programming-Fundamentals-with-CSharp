using System;

namespace P05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = CalculateSum(num1, num2);
            int result = SubtractFromSum(sum, num3);
                        
            Console.WriteLine(result);
        }

        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int SubtractFromSum(int sum, int num3)
        {
            return sum - num3;
        }
    }
}
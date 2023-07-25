using System;
using System.Dynamic;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            int[] arrayNum1 = new int[inputCount];
            int[] arrayNum2 = new int[inputCount];

            for (int i = 0; i < inputCount; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    arrayNum1[i] = input[0];
                    arrayNum2[i] = input[1];
                }
                else
                {
                    arrayNum1[i] = input[1];
                    arrayNum2[i] = input[0];
                }
            }

            Console.WriteLine(string.Join(" ", arrayNum1));
            Console.WriteLine(string.Join(" ", arrayNum2));
        }
    }
}
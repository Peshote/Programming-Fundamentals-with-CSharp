using System;

namespace P12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isSpacialNum = false;
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int currDigit = i;
                while (currDigit != 0)
                {
                    sum += currDigit % 10;
                    currDigit = currDigit / 10;
                }
                isSpacialNum = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpacialNum);
            }
        }
    }
}
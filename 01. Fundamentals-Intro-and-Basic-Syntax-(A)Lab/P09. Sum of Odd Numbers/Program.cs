using System;

namespace P09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                else
                {
                    n++;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
using System;

namespace P07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, repeatCount));
        }

        private static string RepeatString(string input, int repeatCount)
        {
            string result = "";

            for (int i = 0; i < repeatCount; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
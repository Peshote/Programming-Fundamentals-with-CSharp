using System;

namespace P02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            string numberString = inputNum.ToString();
            int numLenght = numberString.Length;
            int result = 0;


            for (int i = 1; i <= numLenght; i++)
            {
                char digitChar = numberString[numLenght - i];
                int currentDigit = int.Parse(digitChar.ToString());
                result += currentDigit;
            }
            Console.WriteLine(result);
        }
    }
}
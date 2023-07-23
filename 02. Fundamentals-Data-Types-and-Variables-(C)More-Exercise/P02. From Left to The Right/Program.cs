using System;

namespace P02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string numbersString = Console.ReadLine();

                string[] numbers = numbersString.Split(' ');

                long number1 = long.Parse(numbers[0]);
                long number2 = long.Parse(numbers[1]);

                long biggerNumber = Math.Max(number1, number2);

                char[] charArray = Math.Abs(biggerNumber).ToString().ToCharArray();
                
                int sumOfDigits = 0;

                for (int j = 0; j < charArray.Length; j++)
                {
                    sumOfDigits += int.Parse(charArray[j].ToString());
                }
                
                Console.WriteLine(sumOfDigits);
            }
        }
    }
}
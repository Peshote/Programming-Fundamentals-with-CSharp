using System;

namespace P01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            double firstNumber;
            double secondNumber;
            double thirdNumber;

            if (number1 >= number2 && number1 >= number3)
            {
                firstNumber = number1;

                if (number2 >= number3)
                {
                    secondNumber = number2;
                    thirdNumber = number3;
                }
                else
                {
                    secondNumber = number3;
                    thirdNumber = number2;
                }
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                firstNumber = number2;

                if (number1 >= number3)
                {
                    secondNumber = number1;
                    thirdNumber = number3;
                }
                else
                {
                    secondNumber = number3;
                    thirdNumber = number1;
                }
            }
            else
            {
                firstNumber = number3;

                if (number1 >= number2)
                {
                    secondNumber = number1;
                    thirdNumber = number2;
                }
                else
                {
                    secondNumber = number2;
                    thirdNumber = number1;
                }
            }

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}
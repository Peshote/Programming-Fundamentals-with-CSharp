using System;
using System.Text.RegularExpressions;

namespace P06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();
                
                if (input == "(")
                {
                   counter++;
                }
                else if (input == ")")
                {
                   counter--;
                }

                if (counter < 0 || counter > 1)
                {
                    break;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
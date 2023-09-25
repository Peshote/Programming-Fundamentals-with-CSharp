using System;

namespace P03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = Console.ReadLine()[0];
            char secondChar = Console.ReadLine()[0];

            PrintCharactersBetween(firstChar, secondChar);
        }
        static void PrintCharactersBetween(char firstChar, char secondChar)
        {            
            if (secondChar < firstChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }
            
            for (char c = (char)(firstChar + 1); c < secondChar; c++)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
    }
}
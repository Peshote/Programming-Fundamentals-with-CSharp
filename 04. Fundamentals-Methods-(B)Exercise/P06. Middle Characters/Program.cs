﻿using System;

namespace P06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }

        static void PrintMiddleCharacter(string input)
        {
            int length = input.Length;
            int middleIndex = length / 2;

            if (length % 2 == 0)
            {
                char middleChar1 = input[middleIndex - 1];
                char middleChar2 = input[middleIndex];
                Console.WriteLine($"{middleChar1}{middleChar2}");
            }
            else
            {
                char middleChar = input[middleIndex];
                Console.WriteLine(middleChar);
            }
        }
    }
}
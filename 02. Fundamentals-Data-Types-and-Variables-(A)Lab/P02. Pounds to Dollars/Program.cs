﻿using System;

namespace P02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());
            double usDollars = britishPounds * 1.31;

            Console.WriteLine($"{usDollars:F3}");
        }
    }
}
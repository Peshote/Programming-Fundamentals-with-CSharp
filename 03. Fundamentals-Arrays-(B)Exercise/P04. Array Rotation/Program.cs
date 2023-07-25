using System;
using System.Linq;

namespace P04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationsCount; i++)
            {
                int firstElement = numbersArray[0];
                Array.Copy(numbersArray, 1, numbersArray, 0, numbersArray.Length -1);
                numbersArray[numbersArray.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", numbersArray));
        }
    }
}
using System;

namespace P02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                   

            uint[] topRow = new uint[1];
            topRow[0] = 1;

            Console.WriteLine(topRow[0]);

            for (int i = 0; i < n-1; i++)
            {
                topRow[0] = 1;
                topRow[topRow.Length - 1] = 1;

                uint[] currentRow = new uint[topRow.Length + 1];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;

                for (int j = 1; j < currentRow.Length - 1; j++)
                {
                    currentRow[j] = topRow[j - 1] + topRow[j];
                }
                topRow = currentRow;

                Console.WriteLine(string.Join(" ", topRow));
            }
        }
    }
}
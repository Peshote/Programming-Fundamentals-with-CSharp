using System;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] peopleCountPerVagon = new int[wagonsCount];
            int totalPassangersCount = 0;

            for (int i = 0; i < peopleCountPerVagon.Length; i++)
            {
                peopleCountPerVagon[i] = int.Parse(Console.ReadLine());
                totalPassangersCount += peopleCountPerVagon[i];
            }

            Console.WriteLine(string.Join(" ", peopleCountPerVagon));
            Console.WriteLine(totalPassangersCount);
        }
    }
}
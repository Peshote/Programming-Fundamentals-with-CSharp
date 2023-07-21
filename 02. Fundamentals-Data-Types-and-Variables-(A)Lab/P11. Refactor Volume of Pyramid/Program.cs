using System;

namespace P11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double pyramidVolume = (length * width * height) / 3;
            Console.Write($"Pyramid Volume: {pyramidVolume:f2}");
        }
    }
}
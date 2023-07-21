using System;

namespace P09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstInput}{secondInput}{thirdInput}");
        }
    }
}
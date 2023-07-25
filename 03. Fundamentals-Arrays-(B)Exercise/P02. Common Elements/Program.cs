using System;
using System.Linq;

namespace P02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').ToArray();
            var array2 = Console.ReadLine().Split(' ').ToArray();

            var commonElements = array2.Intersect(array1);
            string commonElementsString = string.Join(" ", commonElements);

            Console.WriteLine(commonElementsString);
        }
    }
}
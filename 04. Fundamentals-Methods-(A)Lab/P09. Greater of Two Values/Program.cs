using System;

namespace P09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            switch (valueType)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(a, b));
                    break;
                case "char":
                    char c = char.Parse(Console.ReadLine());
                    char d = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(c, d));
                    break;
                case "string":
                    string e = Console.ReadLine();
                    string f = Console.ReadLine();
                    Console.WriteLine(GetMax(e, f));
                    break;
            }       
        }
        public static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        public static char GetMax(char c, char d)
        {
            return c > d ? c : d;
        }
        public static string GetMax(string e, string f)
        {
            return string.Compare(e, f) > 0 ? e : f;
        }
    }
}
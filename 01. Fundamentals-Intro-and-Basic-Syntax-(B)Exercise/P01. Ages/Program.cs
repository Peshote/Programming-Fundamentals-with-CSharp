using System;

namespace P01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personAge = "";
            int ageRange = int.Parse(Console.ReadLine());

            if (ageRange >= 0 && ageRange <= 2)
            {
                personAge = "baby";
            }
            else if (ageRange >= 3 && ageRange <= 13)
            {
                personAge = "child";
            }
            else if (ageRange >= 14 && ageRange <= 19)
            {
                personAge = "teenager";
            }
            else if (ageRange >= 20 && ageRange <= 65)
            {
                personAge = "adult";
            }
            else
            {
                personAge = "elder";
            }
            Console.WriteLine(personAge);
        }
    }
}
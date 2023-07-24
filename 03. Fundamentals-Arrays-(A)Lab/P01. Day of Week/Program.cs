using System;
using System.Dynamic;
using System.Net;

namespace P01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = 
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <=7)
            {
                Console.Write(days[day -1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
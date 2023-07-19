using System;
using System.Diagnostics;

namespace P03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            
            double totalPrice = 0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = peopleCount * 8.45;
                            break;
                        case "Saturday":
                            totalPrice = peopleCount * 9.80;
                            break;
                        case "Sunday":
                            totalPrice = peopleCount * 10.46;
                            break;
                    }
                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;

                case "Business":
                    switch(dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = peopleCount * 10.90;
                            break;
                        case "Saturday":
                            totalPrice = peopleCount * 15.60;
                            break;
                        case "Sunday":
                            totalPrice = peopleCount * 16;
                            break;
                    }
                    if (peopleCount >= 100)
                    {
                        totalPrice = (totalPrice / peopleCount) * (peopleCount-10);
                    }
                    break;

                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = peopleCount * 15;
                            break;
                        case "Saturday":
                            totalPrice = peopleCount * 20;
                            break;
                        case "Sunday":
                            totalPrice = peopleCount * 22.50;
                            break;
                    }
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
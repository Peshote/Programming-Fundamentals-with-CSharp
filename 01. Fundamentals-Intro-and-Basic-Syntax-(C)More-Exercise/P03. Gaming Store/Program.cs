using System;

namespace P03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyCount = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double totalSpent = 0;
            string valideGames = "";
            
            while (input != "Game Time")
            {
                if (input != "Game Time")
                {
                    valideGames = input;

                    switch (valideGames)
                    {
                        case "OutFall 4":
                            if (moneyCount >= 39.99)
                            {
                                Console.WriteLine($"Bought {valideGames}");
                                moneyCount -= 39.99;
                                totalSpent += 39.99;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "CS: OG":
                            if (moneyCount >= 15.99)
                            {
                                Console.WriteLine($"Bought {valideGames}");
                                moneyCount -= 15.99;
                                totalSpent += 15.99;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "Zplinter Zell":
                            if (moneyCount >= 19.99)
                            {
                                Console.WriteLine($"Bought {valideGames}");
                                moneyCount -= 19.99;
                                totalSpent += 19.99;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "Honored 2":
                            if (moneyCount >= 59.99)
                            {
                                Console.WriteLine($"Bought {valideGames}");
                                moneyCount -= 59.99;
                                totalSpent += 59.99;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "RoverWatch":
                            if (moneyCount >= 29.99)
                            {
                                Console.WriteLine($"Bought {valideGames}");
                                moneyCount -= 29.99;
                                totalSpent += 29.99;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "RoverWatch Origins Edition":
                            if (moneyCount >= 39.99)
                            {
                                Console.WriteLine($"Bought {valideGames}");
                                moneyCount -= 39.99;
                                totalSpent += 39.99;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            break;
                    }
                    if (moneyCount == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    input = Console.ReadLine();
                }
            }
            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${moneyCount:F2}");
            }
        }
    }
}
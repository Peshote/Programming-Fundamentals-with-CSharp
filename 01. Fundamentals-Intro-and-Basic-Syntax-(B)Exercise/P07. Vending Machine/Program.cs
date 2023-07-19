using System;

namespace P07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double coin = 0;
            double coinsSum = 0;
            string product = "";
            
            while (input != "Start")
            {
                if (input != "Start")
                {
                    coin = double.Parse(input);

                    switch (coin)
                    {
                        case 0.1:
                            coinsSum += coin;
                            break;
                        case 0.2:
                            coinsSum += coin;
                            break;
                        case 0.5:
                            coinsSum += coin;
                            break;
                        case 1:
                            coinsSum += coin;
                            break;
                        case 2:
                            coinsSum += coin;
                            break;
                        default:
                            Console.WriteLine($"Cannot accept {coin}");
                            break;
                    }
                    input = Console.ReadLine();
                }
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                if (input != "End")
                {
                    product = input;

                    switch (product)
                    {
                        case "Nuts":
                            if (coinsSum >= 2.0)
                            {
                                string output = $"Purchased {product.ToLower()}";
                                Console.WriteLine(output);
                                coinsSum -= 2.0;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":
                            if (coinsSum >= 0.7)
                            {
                                string output = $"Purchased {product.ToLower()}";
                                Console.WriteLine(output);
                                coinsSum -= 0.7;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Crisps":
                            if (coinsSum >= 1.5)
                            {
                                string output = $"Purchased {product.ToLower()}";
                                Console.WriteLine(output);
                                coinsSum -= 1.5;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Soda":
                            if (coinsSum >= 0.8)
                            {
                                string output = $"Purchased {product.ToLower()}";
                                Console.WriteLine(output);
                                coinsSum -= 0.8;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Coke":
                            if (coinsSum >= 1.0)
                            {
                                string output = $"Purchased {product.ToLower()}";
                                Console.WriteLine(output);
                                coinsSum -= 1.0;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }

                    input = Console.ReadLine();
                }
            }

            Console.WriteLine($"Change: {coinsSum:F2}");
        }
    }
}
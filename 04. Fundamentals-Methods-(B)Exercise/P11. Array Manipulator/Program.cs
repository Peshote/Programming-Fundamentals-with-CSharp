using System;
using System.Collections.Generic;
using System.Linq;

namespace P11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(' ');
                string action = tokens[0];

                if (action == "exchange")
                {
                    int index = int.Parse(tokens[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    Exchange(numbers, index);
                }
                else if (action == "max")
                {
                    string type = tokens[1];
                    int index = GetMaxEvenOrOddIndex(numbers, type);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (action == "min")
                {
                    string type = tokens[1];
                    int index = GetMinEvenOrOddIndex(numbers, type);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (action == "first")
                {
                    int count = int.Parse(tokens[1]);
                    string type = tokens[2];
                    if (count < 0 || count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    List<int> result = GetFirstEvenOrOddElements(numbers, count, type);
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
                else if (action == "last")
                {
                    int count = int.Parse(tokens[1]);
                    string type = tokens[2];
                    if (count < 0 || count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    List<int> result = GetLastEvenOrOddElements(numbers, count, type);
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static void Exchange(List<int> numbers, int index)
        {
            List<int> firstPart = numbers.Take(index + 1).ToList();
            List<int> secondPart = numbers.Skip(index + 1).ToList();
            numbers.Clear();
            numbers.AddRange(secondPart);
            numbers.AddRange(firstPart);
        }

        static int GetMaxEvenOrOddIndex(List<int> numbers, string type)
        {
            int maxNumber = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if ((type == "even" && currentNumber % 2 == 0)
                    || (type == "odd" && currentNumber % 2 != 0))
                {
                    if (currentNumber >= maxNumber)
                    {
                        maxNumber = currentNumber;
                        maxIndex = i;
                    }
                }
            }

            return maxIndex;
        }

        static int GetMinEvenOrOddIndex(List<int> numbers, string type)
        {
            int minNumber = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if ((type == "even" && currentNumber % 2 == 0)
                    || (type == "odd" && currentNumber % 2 != 0))
                {
                    if (currentNumber <= minNumber)
                    {
                        minNumber = currentNumber;
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }

        static List<int> GetFirstEvenOrOddElements(List<int> numbers, int count, string type)
        {
            List<int> result = new List<int>();
            int foundCount = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if ((type == "even" && currentNumber % 2 == 0)
                    || (type == "odd" && currentNumber % 2 != 0))
                {
                    result.Add(currentNumber);
                    foundCount++;

                    if (foundCount == count)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        static List<int> GetLastEvenOrOddElements(List<int> numbers, int count, string type)
        {
            List<int> result = new List<int>();
            int foundCount = 0;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int currentNumber = numbers[i];

                if ((type == "even" && currentNumber % 2 == 0)
                    || (type == "odd" && currentNumber % 2 != 0))
                {
                    result.Insert(0, currentNumber);
                    foundCount++;

                    if (foundCount == count)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}
using System;
using System.Linq;
using System.Net;

namespace P10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] fieldCells = new int[fieldSize];
            int[] initialBugsLocation = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < initialBugsLocation.Length; i++)
            {
                if (initialBugsLocation[i] >= 0 && initialBugsLocation[i] < fieldSize)
                {
                    fieldCells[initialBugsLocation[i]] = 1;
                }
            }

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] commandsArray = commands
                    .Split()
                    .ToArray();


                int ladyBugIndex = int.Parse(commandsArray[0]);
                bool directionRigh = commandsArray[1] == "right";
                int flyLength = int.Parse(commandsArray[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= fieldSize || fieldCells[ladyBugIndex] == 0 || flyLength == 0)
                {
                    commands = Console.ReadLine();
                    continue;
                }

                int newLadyBugLocation = ladyBugIndex;

                if (directionRigh)
                {
                    newLadyBugLocation += flyLength;
                }
                else
                {
                    newLadyBugLocation -= flyLength;
                }

                while (true)
                {
                    if (newLadyBugLocation < 0 || newLadyBugLocation >= fieldSize)
                    {
                        fieldCells[ladyBugIndex] = 0;
                        break;
                    }

                    if (fieldCells[newLadyBugLocation] == 0)
                    {
                        fieldCells[newLadyBugLocation] = 1;
                        fieldCells[ladyBugIndex] = 0;
                        break;
                    }

                    if (directionRigh)
                    {
                        newLadyBugLocation += flyLength;
                    }
                    else
                    {
                        newLadyBugLocation -= flyLength;
                    }
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", fieldCells));
            int self = 0;
        }
    }
}
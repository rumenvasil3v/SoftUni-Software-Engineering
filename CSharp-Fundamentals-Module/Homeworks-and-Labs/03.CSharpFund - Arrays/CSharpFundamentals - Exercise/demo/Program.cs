using System;
using System.Linq;
using System.Net.Sockets;

/*
If we receive an initial index that does not contain a ladybug, nothing happens. If you are given a ladybug index that
is outside the field, nothing happens

3
0 1
0 right 1
2 right 1
end
 */
namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fieldSize = long.Parse(Console.ReadLine());

            long[] finalCells = new long[fieldSize];

            long[] initialIndexes = Console.ReadLine().Split(separator: ' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            long[] currentCells = new long[fieldSize]; // if a cell has a ladybug in it, print '1',
            // if a cell is empty, print '0'

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < initialIndexes.Length; j++)
                {
                    if (initialIndexes[j] == i)
                    {
                        currentCells[i] = 1;
                    }
                }
            }

            long[] currentIndex = new long[100];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                currentIndex[i] = initialIndexes[i];
            }

            bool isTrue = true;

            string input = Console.ReadLine();
            while (input != "end")
            {
                for (int i = 0; i <= 100; i++)
                {

                    if (input == "end")
                    {
                        break;
                    }

                    int ladyBugIndex = 0;
                    string direction = string.Empty;
                    int flyLength = 0;

                    string[] ladyBugFlyDirection = new string[100];
                    ladyBugFlyDirection = input.Split(separator: ' ', StringSplitOptions.RemoveEmptyEntries);

                    ladyBugIndex = int.Parse(ladyBugFlyDirection[0]);
                    direction = ladyBugFlyDirection[1];
                    flyLength = int.Parse(ladyBugFlyDirection[2]);

                    if (ladyBugIndex >= fieldSize || ladyBugIndex < 0)
                    {
                        break;
                    }

                    for (int j = 0; j < initialIndexes.Length; j++)
                    {
                        if (currentIndex[j] == ladyBugIndex)
                        {
                            isTrue = false;
                            break;
                        }
                    }

                    if (isTrue)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    if (direction == "right")
                    {
                        if (ladyBugIndex + flyLength > currentCells.Length - 1)
                        {
                            currentCells[ladyBugIndex] = 0;
                            input = Console.ReadLine();
                            continue;
                        }

                        if (currentCells[ladyBugIndex + flyLength] == 1)
                        {
                            if (ladyBugIndex + flyLength >= currentCells.Length - 1)
                            {
                                currentCells[ladyBugIndex] = 0;
                                input = Console.ReadLine();
                                continue;
                            }

                            currentCells[ladyBugIndex + flyLength + 1] = 1;
                            currentIndex[i] = ladyBugIndex + flyLength + 1;
                            currentCells[ladyBugIndex] = 0;
                            input = Console.ReadLine();
                            continue;
                        }

                        currentCells[ladyBugIndex + flyLength] = 1;
                        currentIndex[i] = ladyBugIndex + flyLength;
                        currentCells[ladyBugIndex] = 0;
                    }
                    else if (direction == "left")
                    {
                        if (ladyBugIndex - flyLength < currentCells.Length - currentCells.Length)
                        {
                            currentCells[ladyBugIndex] = 0;
                            input = Console.ReadLine();
                            continue;
                        }

                        if (currentCells[ladyBugIndex - flyLength] == 1)
                        {
                            if (ladyBugIndex - flyLength - 1 < currentCells.Length - currentCells.Length)
                            {
                                currentCells[ladyBugIndex] = 0;
                                input = Console.ReadLine();
                                continue;
                            }

                            currentCells[ladyBugIndex - flyLength - 1] = 1;
                            currentIndex[i] = ladyBugIndex - flyLength - 1;
                            currentCells[ladyBugIndex] = 0;
                            input = Console.ReadLine();
                            continue;
                        }

                        currentCells[ladyBugIndex - flyLength] = 1;
                        currentIndex[i] = ladyBugIndex - flyLength;
                        currentCells[ladyBugIndex] = 0;
                    }

                    input = Console.ReadLine();
                }
            }

            finalCells = currentCells;
            Console.WriteLine(string.Join(' ', finalCells));
        }
    }
}
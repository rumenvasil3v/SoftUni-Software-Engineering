using System;
using System.Linq;

namespace _10._LadyBugs___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short fieldSize = short.Parse(Console.ReadLine());

            short[] cells = new short[fieldSize];

            short[] initialIndex = Console
                .ReadLine()
                .Split()
                .Select(short.Parse)
                .ToArray();

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < initialIndex.Length; j++)
                {
                    if (initialIndex[j] == i)
                    {
                        cells[i] = 1;
                        break;
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(); // 0 right 1

                int ladybugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLength = int.Parse(arguments[2]);

                int currentFlyLength = flyLength;
                bool isOutside = false;
                bool isValid = false;

                if (flyLength == 0)
                {
                    continue;
                }

                for (int i = 0; i < cells.Length; i++)
                {
                    if (cells[i] == 1)
                    {
                        if (ladybugIndex == i)
                        {
                            isValid = true;
                            break;
                        }
                    }
                }

                if (!isValid)
                {
                    continue;
                }

                if (direction == "right")
                {

                    if (ladybugIndex + flyLength > cells.Length - 1 || ladybugIndex + flyLength < 0)
                    {
                        cells[ladybugIndex] = 0;
                        continue;
                    }

                    while (cells[ladybugIndex + flyLength] == 1)
                    {

                        flyLength += currentFlyLength;
                        if (ladybugIndex + flyLength > cells.Length - 1 || ladybugIndex + flyLength < 0)
                        {
                            cells[ladybugIndex] = 0;
                            isOutside = true;
                            break;
                        }
                    }

                    if (isOutside)
                    {
                        continue;
                    }

                    cells[ladybugIndex + flyLength] = 1;
                    cells[ladybugIndex] = 0;
                }
                else if (direction == "left")
                {
                    if (ladybugIndex - flyLength < 0 || ladybugIndex - flyLength > cells.Length - 1)
                    {
                        cells[ladybugIndex] = 0;
                        continue;
                    }

                    while (cells[ladybugIndex - flyLength] == 1)
                    {
                        flyLength += currentFlyLength;
                        if (ladybugIndex - flyLength < 0 || ladybugIndex - flyLength > cells.Length - 1)
                        {
                            cells[ladybugIndex] = 0;
                            isOutside = true;
                            break;
                        }
                    }

                    if (isOutside)
                    {
                        continue;
                    }

                    cells[ladybugIndex - flyLength] = 1;
                    cells[ladybugIndex] = 0;
                }
            }

            Console.WriteLine(string.Join(" ", cells));
        }
    }
}
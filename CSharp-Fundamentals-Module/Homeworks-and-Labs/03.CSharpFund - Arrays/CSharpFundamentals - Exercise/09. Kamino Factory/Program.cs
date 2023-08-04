using System;
using System.Linq;
/*
 5
1!0!1!1!0
0!1!1!0!0
Clone them!

4
1!1!0!1
1!0!0!1
1!1!0!0
Clone them!

 */
namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfDna = int.Parse(Console.ReadLine());

            int[] bestDna = new int[sizeOfDna];

            int index = 0;
            int bestIndex = 1;
            int startingIndex = 0;
            int bestSum = 0;
            int bestLength = 0;

            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int currentSum = 0;
                int currentIndex = 0;
                int currentLength = 0;
                int length = 0;
                index++;

                int[] array = input
                    .Split(separator: "!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1)
                    {
                        length++;

                        if (length > currentLength)
                        {
                            currentLength = length;
                            currentIndex = i;
                        }
                    }
                    else
                    {
                        length = 0;
                    }
                }

                currentIndex = currentIndex - currentLength + 1;

                currentSum = array.Sum();

                if (currentLength > bestLength || (currentLength == bestLength && startingIndex > currentIndex))
                {
                    bestSum = currentSum;
                    bestIndex = index;
                    bestDna = array;
                    startingIndex = currentIndex;
                    bestLength = currentLength;
                }
                else if (currentLength == bestLength && startingIndex == currentIndex && currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestIndex = index;
                    bestDna = array;
                    startingIndex = currentIndex;
                    bestLength = currentLength;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}    
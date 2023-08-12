using System;
using System.Collections.Generic;
using System.Linq;
/*
 3 5 2 43 12 3 54 10 23
76 5 34 2 4 12

76 5 34 2 4 12
3 5 2 43 12 3 54 10 23
 */
namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> firstNumbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> secondNumbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> containNumbers = new List<double>();

            for (int firstNums = 0; firstNums < firstNumbers.Count; firstNums++)
            {
                containNumbers.Add(firstNumbers[firstNums]);

                for (int secondNums = firstNums; secondNums < secondNumbers.Count; secondNums++)
                {
                    if (firstNums == firstNumbers.Count - 1)
                    {
                        containNumbers.Add(secondNumbers[secondNums]);
                        continue;
                    }
                    containNumbers.Add(secondNumbers[secondNums]);
                    break;
                }
            }

            Console.WriteLine(string.Join(' ', containNumbers));
        }
    }
}

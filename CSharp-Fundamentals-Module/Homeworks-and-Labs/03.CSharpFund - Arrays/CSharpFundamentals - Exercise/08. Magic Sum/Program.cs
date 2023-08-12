using System;
using System.Linq;
/*
 1 7 6 2 19 23
8
14 20 60 13 7 19 8
27
 */
namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] uniquePairs = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int uniqueNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < uniquePairs.Length; i++)
            {
                for (int j = i + 1; j < uniquePairs.Length; j++)
                {
                    if (Math.Abs((uniquePairs[i] + uniquePairs[j])) == Math.Abs(uniqueNumber))
                    {
                        Console.WriteLine($"{Math.Abs(uniquePairs[i])} {Math.Abs(uniquePairs[j])}");
                    }
                }
            }
        }
    }
}

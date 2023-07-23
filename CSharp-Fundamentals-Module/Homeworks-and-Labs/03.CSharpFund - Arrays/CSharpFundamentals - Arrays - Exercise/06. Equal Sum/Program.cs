using System;
using System.Linq;
/*
 1 2 3 3
1 2
1
1 2 3 
10 5 5 99 3 4 2 5 1 1 4
 */
namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] equalSums = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rightSum = 0;
            int leftSum = 0;
            bool exist = false;

            for (int i = 0; i < equalSums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += equalSums[j];
                }

                for (int j = equalSums.Length - 1; j > i; j--)
                {
                    rightSum += equalSums[j];
                }

                if (leftSum == rightSum)
                {
                    exist = true;
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    exist = false;
                    rightSum = 0;
                    leftSum = 0;
                }
            }

            if (!exist)
            {
                Console.WriteLine("no");
            }
        }
    }
}

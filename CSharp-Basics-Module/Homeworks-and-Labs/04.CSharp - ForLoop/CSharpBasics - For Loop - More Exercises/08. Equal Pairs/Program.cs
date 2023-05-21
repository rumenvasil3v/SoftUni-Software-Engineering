using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int sum = 0;
            int pairDifference = 0;

            for (int i = 1; i <= n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                
                int pairsSum = num1 + num2;
                
                if (i == 1)
                {
                    sum = pairsSum;
                }
                else
                {
                    pairDifference = Math.Abs(sum - pairsSum);
                    sum = pairsSum;
                }
                if (pairDifference > maxNum)
                {
                    maxNum= pairDifference;
                }
            }
   
            if (maxNum == 0)
            { 
                Console.WriteLine($"Yes, value={sum}");
            }

            else
            {
                Console.WriteLine($"No, maxdiff={pairDifference}");
            }
        }
    }
}

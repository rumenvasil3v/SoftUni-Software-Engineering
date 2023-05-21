using System;

namespace _02._Equal_Sums_Even_Odd_Position___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int x1 = num1; x1 <= num2; x1++)
            {
                string currentNum = x1.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int x2 = 0; x2 < currentNum.Length; x2++)
                {
                    int currentDigit = int.Parse(currentNum[x2].ToString());
                    if (x2 % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(x1 + " ");
                }
            }
        }
    }
}

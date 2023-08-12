using System;

namespace _10.MultiEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenSum = GetSumOfEvenDigits(Math.Abs(number));
            int oddSum = GetSumOffOddDigits(Math.Abs(number));
            int multipleOfEvensAndOdds = GetMultipleOfEvensAndOdds(evenSum, oddSum);
            Console.WriteLine(multipleOfEvensAndOdds);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenDigitsSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    evenDigitsSum += lastDigit;
                }
                number /= 10;
            }

            return evenDigitsSum;
        }

        static int GetSumOffOddDigits(int number)
        {
            int oddDigitsSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 1)
                {
                    oddDigitsSum += lastDigit;
                }

                number /= 10;
            }

            return oddDigitsSum;
        }

        static int GetMultipleOfEvensAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}

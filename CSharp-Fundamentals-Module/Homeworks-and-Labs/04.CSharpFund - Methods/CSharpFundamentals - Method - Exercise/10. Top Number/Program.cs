using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = int.Parse(Console.ReadLine());
            PrintTopNumbers(randomNumber);
        }

        static void PrintTopNumbers(int endValueNumber)
        {
            for (int i = 1; i <= endValueNumber; i++)
            {
                bool sumOfDigits = false;
                sumOfDigits = SumOfDigits(i, sumOfDigits);

                bool oddDigits = false;
                oddDigits = OddDigit(i, oddDigits);

                if (sumOfDigits && oddDigits)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumOfDigits(int number, bool isValid)
        {
            int sumOfDigits = 0;
            int currentNumber = number;

            while (currentNumber > 0)
            {
                int lastDigit = currentNumber % 10;
                sumOfDigits += lastDigit;
                currentNumber /= 10;
            }

            if (sumOfDigits % 8 == 0)
            {
                isValid = true;
            }

            return isValid;
        }

        static bool OddDigit(int number, bool isValid)
        {
            int currentNumber = number;

            while (currentNumber > 0)
            {
                int lastDigit = currentNumber % 10;

                if (lastDigit % 2 == 1)
                {
                    isValid = true;
                    break;
                }

                currentNumber /= 10;
            }

            return isValid;
        }
    }
}

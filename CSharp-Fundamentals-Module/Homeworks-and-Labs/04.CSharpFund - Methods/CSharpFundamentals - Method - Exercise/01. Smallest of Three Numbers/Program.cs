using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = int.Parse(Console.ReadLine());

            int smallestNumber = SmallestOfTheseThreeNumbers(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(smallestNumber);
        }

        static int SmallestOfTheseThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallestNumber = 0;

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    smallestNumber = thirdNumber;
                }
                else
                {
                    smallestNumber = secondNumber;
                }
            }
            else if (secondNumber > thirdNumber && secondNumber > firstNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    smallestNumber = thirdNumber;
                }
                else
                {
                    smallestNumber = firstNumber;
                }
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    smallestNumber = secondNumber;
                }
                else
                {
                    smallestNumber = firstNumber;
                }
            }
            else
            {
                smallestNumber = firstNumber;
            }

            return smallestNumber;
        }
    }
}

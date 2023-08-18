using System;

namespace _05.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            ZeroProduct(firstNumber, secondNumber, thirdNumber);
            NegativeProduct(firstNumber, secondNumber, thirdNumber);
            PositiveProduct(firstNumber, secondNumber, thirdNumber);
        }

        static void PositiveProduct(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                Console.WriteLine("positive");
            }
            else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
            {
                Console.WriteLine("positive");
            }
            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
            {
                Console.WriteLine("positive");
            }
            else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
            {
                Console.WriteLine("positive");
            }
        }

        static void NegativeProduct(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
            {
                if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0
                    || (firstNumber < 0 && secondNumber < 0) || (firstNumber < 0
                 && thirdNumber < 0) || (secondNumber < 0 && thirdNumber < 0))
                {
                    if (thirdNumber < 0 && secondNumber < 0 && firstNumber < 0)
                    {
                        Console.WriteLine("negative");
                    }
                    return;
                }
                Console.WriteLine("negative");
            }
        }

        static void ZeroProduct(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}

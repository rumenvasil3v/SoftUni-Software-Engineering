using System;

namespace _11.MathOperat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char arithmeticOperation = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (arithmeticOperation == '+')
            {
                int mathOperationAdd = ArithmeticOperationAdd(firstNumber, secondNumber);
                Console.WriteLine(mathOperationAdd);
            }
            else if (arithmeticOperation == '-')
            {
                int mathOperationSubtract = ArithmeticOperationSubtract(firstNumber, secondNumber);
                Console.WriteLine(mathOperationSubtract);
            }
            else if (arithmeticOperation == '*')
            {
                int mathOperationMultiply = ArithmeticOperationMultiply(firstNumber, secondNumber);
                Console.WriteLine(mathOperationMultiply);
            }
            else if (arithmeticOperation == '/')
            {
                int mathOperationDivide = ArithmeticOperationDivide(firstNumber, secondNumber);
                Console.WriteLine(mathOperationDivide);
            }
        }

        static int ArithmeticOperationAdd(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int ArithmeticOperationSubtract(int firsNumber, int secondNumber)
        {
            return firsNumber - secondNumber;
        }

        static int ArithmeticOperationMultiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static int ArithmeticOperationDivide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}

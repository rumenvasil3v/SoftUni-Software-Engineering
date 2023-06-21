using System;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arithmeticOperationChoose();
        }

        static void arithmeticOperationChoose()
        {
            string arithmeticOperation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (arithmeticOperation == "add")
            {
                ArithmeticOperationAdd(firstNumber, secondNumber);
            }
            else if (arithmeticOperation == "subtract")
            {
                ArithmeticOperationSubtract(firstNumber, secondNumber);
            }
            else if (arithmeticOperation == "multiply")
            {
                ArithmeticOperationMultiply(firstNumber, secondNumber);
            }
            else if (arithmeticOperation == "divide")
            {
                ArithmeticOperationDivide(firstNumber, secondNumber);
            }
        }

        static void ArithmeticOperationAdd(int firstNumber, int secondNumber)
        {
            int arithmeticOperationAdd = firstNumber + secondNumber;
            Console.WriteLine(arithmeticOperationAdd);
        }

        static void ArithmeticOperationSubtract(int firstNumber, int secondNumber)
        {
            int arithmeticOperationSubtract = firstNumber - secondNumber;
            Console.WriteLine(Math.Abs(arithmeticOperationSubtract));
        }

        static void ArithmeticOperationMultiply(int firstNumber, int secondNumber)
        {
            int arithmeticOperationMultiply = firstNumber * secondNumber;
            Console.WriteLine(arithmeticOperationMultiply);
        }

        static void ArithmeticOperationDivide(int firstNumber, int secondNumber)
        {
            int arithmeticOperationDivide = firstNumber / secondNumber;
            Console.WriteLine(arithmeticOperationDivide);
        }
    }
}

using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console n1, n2 and operator
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());// '+'; '-';'*';'/';'%'

            //2. Check whether operator is :
            // if (+, -, *) ->
            if (operation == '+' || operation == '-' || operation == '*')
            {
                int result = 0;
                if (operation == '+')
                {
                    result = num1 + num2;
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                }
                else
                {
                    result = num1 * num2;
                }

                string evenOrOdd = "odd";
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            else // operation == '/' || operation == '%'
            { 
              // -> whetehr n2 = 0
              if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
              else if (operation == '/')
                {
                    double result = (double)num1 / num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"{num1} % {num2} = {num1%num2}");
                }
            }
        }
    }
}

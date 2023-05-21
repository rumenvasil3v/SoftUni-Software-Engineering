using System;

namespace _06._Operations_Between_Numbers____exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console num1,num2 and operator
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            //2. Create variable for result
            double result = 0;
            //3. Condition if it's one of these  chars '+','-' or '*'
            if (operation == '+' || operation == '-' || operation == '*')
            {
                //if its true check if operation is '+' and calculate
                if (operation == '+')
                {
                    result = num1 + num2;
                }
                //if its true check if operation is '-' and calculate
                else if (operation == '-')
                {
                    result = num1 - num2;
                }
                //if its true check if operation is '*' and calculate
                else
                {
                    result= num1 * num2;
                }
                // create variable string whether the result is odd or even
                string evenOrOdd = "odd";
                // if the result == 0 ->even
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                // Output
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            //if the condition isn't true check wheter the operations are '/' or '%'
            else
            {
                //Divide by 0 -> 
                // print "Cannot divide {num1} by zero"
                if (num2 == 0)
                {
                    if (operation == '/' || operation == '%') 
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                // operation is '/'
                }
                else if (operation == '/')
                {
                    result = (double)num1 / num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
                }
                // operation is '%'
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {result}");
                }
            }
        }
    }
}

using System;

namespace _02._Multiplication_table___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int multiplierOne = 1; multiplierOne <= 10; multiplierOne++)
            {
                int multiplierTwo = 1;
                while (multiplierTwo <= 10) 
                {
                    Console.WriteLine($"{multiplierOne} * {multiplierTwo} = {multiplierOne * multiplierTwo}");
                    multiplierTwo++;
                }
            }
        }
    }
}

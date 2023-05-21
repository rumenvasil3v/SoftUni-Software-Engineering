using System;

namespace P03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialSum = int.Parse(Console.ReadLine());

            int numbersSum = 0;
            while (numbersSum < initialSum)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                numbersSum += currentNumber;
            }

            Console.WriteLine(numbersSum);
        }
    }
}

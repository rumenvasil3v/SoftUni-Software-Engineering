using System;

namespace P07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // For loop which repeat ReadLine n times
            // [0; n) <=> [1;n] <=> n repetitions
            // Variables that store statistic data about read rows (numbers)
            // in the for loop are always declared before it with default value
            // int product = 1; // Products always start from 1 (N * 1 = N)
            // N + 0 = N;
            int sum = 0; // Sum always starts from 0 (except if you don't want another functionallity)
            for (int i = 0; i < n; i++)
            {
                // Variables inside the loop are being reset on every iteration (row)
                int currentNumber = int.Parse(Console.ReadLine());

                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] % 2 == 0)
                {
                    evenSum += numbers[index];
                }
            }

            Console.WriteLine(evenSum);
        }
    }
}

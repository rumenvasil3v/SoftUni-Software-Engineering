using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            int[] evenOrOdd = items.Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;
   
            for (int index = 0; index < evenOrOdd.Length; index++)
            {
                if (evenOrOdd[index] % 2 == 0)
                {
                    evenSum += evenOrOdd[index];
                }
                else
                {
                    oddSum += evenOrOdd[index];
                }
            }

            int diff = evenSum - oddSum;
            Console.WriteLine(diff);
        }
    }
}

using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string[] secondInput = Console.ReadLine().Split(' ');
            int[] secondArray = secondInput.Select(int.Parse).ToArray();

            bool isValid = false;
            int sumOfArray = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    isValid = true;
                    sumOfArray += firstArray[i];
                }
                else
                {
                    isValid = false;

                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if(isValid)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumOfArray}");
            }
        }
    }
}



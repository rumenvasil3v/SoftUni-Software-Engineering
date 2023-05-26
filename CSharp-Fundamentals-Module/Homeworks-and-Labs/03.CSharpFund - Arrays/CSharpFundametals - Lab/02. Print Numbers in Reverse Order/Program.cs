using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] reverseNumbers = new int[n];

            for (int index = 0; index < reverseNumbers.Length; index++)
            {
                int numbers = int.Parse(Console.ReadLine());

                reverseNumbers[index] = numbers;
            }

            for (int index = reverseNumbers.Length; index > 0; index--)
            {
                Console.Write(reverseNumbers[index - 1] + " ");
            }
        }
    }
}

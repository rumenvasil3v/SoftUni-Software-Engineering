using System;
using System.Linq;
/*
 2 10 3
5 0 4 1 2
1
 */
namespace _08._Condense_Array_to_Number
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

            int[] condensed = new int[numbers.Length];

            int arraySize = condensed.Length - 1;

            while (arraySize > 0)
            {
                if (condensed.Length == 1)
                {
                    break;
                }
         
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];

                    numbers[i] = condensed[i];
                }

                 arraySize -= 1;
            }

            if (condensed.Length == 1)
            {
                condensed[0] = numbers[0];
            }

            Console.WriteLine(condensed[0]);
        }
    }
}
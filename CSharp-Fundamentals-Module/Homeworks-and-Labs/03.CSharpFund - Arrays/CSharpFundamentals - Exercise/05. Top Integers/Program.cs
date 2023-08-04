using System;
using System.Linq;
/*
 1 4 3 2
14 24 3 19 15 17
27 19 42 2 13 45 48
 */
namespace _05._Top_Integers
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

            bool isTop = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[numbers.Length - 1] > numbers[i])
                {
                    isTop = true;
                }
                else
                {
                    isTop = false;
                    break;
                }
            }

            string topInteger = string.Empty;
            if (!isTop)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        topInteger += numbers[i] + " ";
                    }
                }
            }

            if (!isTop)
            {
                topInteger += numbers[numbers.Length - 1];
            }

            if (isTop)
            {
                topInteger += numbers[numbers.Length - 1];
                Console.WriteLine(topInteger);
            }
            else
            {
                Console.WriteLine(topInteger);
            }
        }
    }
}

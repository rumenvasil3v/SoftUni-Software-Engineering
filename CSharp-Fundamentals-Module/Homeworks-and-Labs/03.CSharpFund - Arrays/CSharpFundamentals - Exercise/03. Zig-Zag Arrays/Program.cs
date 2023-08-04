using System;
using System.Linq;
/*
4
1 5
9 10
31 81
41 20

2
80 23
31 19

*/
namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int[] firstNumber = new int[numberOfLines];
            int[] secondNumber = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                int[] numbers = Console
                    .ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
             
                if (i % 2 == 1)
                {
                    secondNumber[i] = numbers[0];
                    firstNumber[i] = numbers[1];
                }
                else
                {
                    firstNumber[i] = numbers[0];
                    secondNumber[i] = numbers[1];
                }
                
            }

            Console.WriteLine(string.Join(' ', firstNumber));
            Console.WriteLine(string.Join(' ', secondNumber));
        }
    }
}

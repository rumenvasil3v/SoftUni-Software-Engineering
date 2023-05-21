using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write($"{current} ");
                    current++;

                    if (current > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();

                if (current > n)
                {
                    break;
                }
            }
        }
    }
}

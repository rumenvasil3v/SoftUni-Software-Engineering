using System;
/*
 3
1000000000000000000
5
10

2
0.00000000003
333333333333.3
 */
namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numbers = byte.Parse(Console.ReadLine());

            float sumOfNumbers = (float)0.0;

            for (int i = 1; i <= numbers; i++)
            {
                float number = float.Parse(Console.ReadLine());
                sumOfNumbers += number;
            }

            Console.WriteLine(sumOfNumbers);
        }
    }
}

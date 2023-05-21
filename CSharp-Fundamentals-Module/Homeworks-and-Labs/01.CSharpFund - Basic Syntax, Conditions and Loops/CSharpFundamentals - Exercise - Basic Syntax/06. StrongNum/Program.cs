using System;

namespace _06._StrongNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strongOrNot = int.Parse(Console.ReadLine());

            int strongNum = strongOrNot;

            int sum = 0;
            int factorial = 1;
            int lastDigit = 0;

            while (strongOrNot > 0)
            {

                lastDigit = strongOrNot % 10;
                int num = strongOrNot / 10;

                for (int i = lastDigit; i >= 1; i--)
                {
                    factorial = factorial * i;
                }

                sum = sum + factorial;
                strongOrNot = num;

                factorial = 1;
            }

            if (sum == strongNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

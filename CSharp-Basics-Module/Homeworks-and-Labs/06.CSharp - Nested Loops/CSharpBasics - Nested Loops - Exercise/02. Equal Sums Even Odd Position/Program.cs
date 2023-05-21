using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console start and end of interval
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());


            //2. Make loop, which will execute from 1 -st num to last num
            for (int num = first; num <= second; num++)
            {
                int oddSum = 0;
                int evenSum = 0;

                string currentNum = num.ToString();
                for (int i = 0; i < 6; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += currentNum[i];
                    }
                    else
                    {
                        oddSum += currentNum[i];
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{num + " "}");
                }
                
            }
        }
    }
}

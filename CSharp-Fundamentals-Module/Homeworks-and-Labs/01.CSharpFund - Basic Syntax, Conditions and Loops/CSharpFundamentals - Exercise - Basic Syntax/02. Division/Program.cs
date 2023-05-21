using System;
/*
 30 
 15
 12 
1643 
 */

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());

            int currentNum;
            int maxNum = int.MinValue;
            bool isValid = false;   

            if (number % 2 == 0)
            {
                currentNum = 2;
                if(currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                isValid= true;
            }
            if (number % 3 == 0)
            {
                currentNum = 3;
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                isValid= true;
            }
            if (number % 6 == 0)
            {
                currentNum = 6;
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                isValid= true;
            }
            if (number % 7 == 0)
            {
                currentNum = 7;
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                isValid= true;
            }
            if (number % 10 == 0)
            {
                currentNum = 10;
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                isValid= true;
            }

            if (isValid)
            {
                Console.WriteLine($"The number is divisible by {maxNum}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            //code

        }
    }
}

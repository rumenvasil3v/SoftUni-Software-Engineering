using System;
using System.Drawing;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            long result = 0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                string[] numbers = Console.ReadLine().Split();

                //Parse element 0
                long a = long.Parse(numbers[0]);

                //Parse element 1
                long b = long.Parse(numbers[1]);

                if (a > b)
                {
                    while (a > 0)
                    {
                        long lastDigitA = a % 10;
                        result += lastDigitA;
                        a /= 10;
                    }
                }
                else if (b > a)
                {
                    while (b > 0)
                    {
                        long lastDigitB = b % 10;
                        result += lastDigitB;
                        b /= 10;
                    }
                }
                else if (a == b)
                {
                    while (a > 0 && b > 0)
                    {
                        long lastDigitA = a % 10;
                        result += lastDigitA;
                        a /= 10;

                        long lastDigitB = b % 10;
                        result += lastDigitB;
                        b /= 10;
                    }
                    result /= 2;
                }

                Console.WriteLine(result);

                result = 0;
              
            }
        }
    }
}

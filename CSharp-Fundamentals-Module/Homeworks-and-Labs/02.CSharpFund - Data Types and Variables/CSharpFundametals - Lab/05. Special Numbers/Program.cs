using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte specialNumber = byte.Parse(Console.ReadLine());

            byte sum = 0;

            for (byte i = 1; i <= specialNumber; i++)
            {
                byte number = i;

                while (number > 0)
                {
                    byte lastDigit = (byte)(number % 10);
                    sum = (byte)(sum + lastDigit);
                    number = (byte)(number / 10); 
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

                sum = 0;
            }
        }
    }
}

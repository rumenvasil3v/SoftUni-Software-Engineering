using System;
/*
 245678 
97561 
543
 */
namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            byte sumOfDigits = 0;
            while (number > 0)
            {
                sumOfDigits += (byte)(number % 10);
                number /= 10;
            }

            Console.WriteLine(sumOfDigits);
        }
    }
}

using System.Numerics;
using System.Runtime.InteropServices;

namespace _04.Tribonacci_Seq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            GetTribonacciNumber(number);
        }

        static void GetTribonacciNumber(int number)
        {
            BigInteger[] tribonnaciNumbers = new BigInteger[number];

            if (number >= 3)
            {
                tribonnaciNumbers[0] = 1;
                tribonnaciNumbers[1] = 1;
                tribonnaciNumbers[2] = 2;
            }
            else if (number == 2)
            {
                tribonnaciNumbers[0] = 1;
                tribonnaciNumbers[1] = 1;
            }
            else
            {
                tribonnaciNumbers[0] = 1;
            }

            for (int n = 3; n < number; n++)
            {
                tribonnaciNumbers[n] = tribonnaciNumbers[n - 1] + tribonnaciNumbers[n - 2] + tribonnaciNumbers[n - 3];
            }

            Console.WriteLine(string.Join(" ", tribonnaciNumbers));
        }
    }
}
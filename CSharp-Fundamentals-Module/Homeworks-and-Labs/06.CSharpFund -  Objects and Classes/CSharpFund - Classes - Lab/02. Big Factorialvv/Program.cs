using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // read random number from the console
            BigInteger factorial = 1; // create variable from BigInteger type

            CalculateFactorial(factorial, number);

            Console.WriteLine(CalculateFactorial(factorial, number)); // print on the console calculate factorial of a given n!
        }

        static BigInteger CalculateFactorial(BigInteger factorial, int number)
        {
            for (int i = number; i >= 2; i -= 2)
            {
                factorial *= i * (i - 1); // calculate the factorial of a given n!
            }

            return factorial;
        }
    }
}
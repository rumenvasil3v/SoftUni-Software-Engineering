using System;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int primeOrNot = 2; primeOrNot <= n; primeOrNot++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor < primeOrNot; divisor++)
                {
                    if (primeOrNot % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", primeOrNot, isPrime.ToString().ToLower());
            }
        }
    }
}

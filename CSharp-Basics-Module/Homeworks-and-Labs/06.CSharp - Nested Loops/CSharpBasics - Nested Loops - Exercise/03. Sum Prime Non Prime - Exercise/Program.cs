using System;

namespace _03._Sum_Prime_Non_Prime___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int currentNum;
            bool isPrime;

            int primeSum = 0;
            int nonPrimeSum = 0;
            while (input != "stop")
            {
                currentNum = int.Parse(input);
                isPrime = true;

                if (currentNum < 0)
                {
                    Console.WriteLine("Nember is negative.");
                }
                else
                {
                    for (int i = 2; i < currentNum; i++)
                    {
                       if (currentNum%i == 0)
                        {
                            isPrime= false;
                            break;
                        }
                    }
                }

                if (isPrime && currentNum > 0)
                {

                    primeSum+= currentNum;
                }
                else if (currentNum>0)
                {
                    nonPrimeSum+= currentNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime number is: {nonPrimeSum}");
        }
    }
}

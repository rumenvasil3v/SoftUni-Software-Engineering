using System;

namespace _13._Prime_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstPairStart = int.Parse(Console.ReadLine());
            int secondPairStart = int.Parse(Console.ReadLine());
            int firstPairEnd = int.Parse(Console.ReadLine());
            firstPairEnd = firstPairStart + firstPairEnd;
            int secondPairEnd = int.Parse(Console.ReadLine());
            secondPairEnd = secondPairStart + secondPairEnd;

            bool isPrime = false;

            for (int a = firstPairStart; a <= firstPairEnd; a++)
            {
                for (int b = secondPairStart; b <= secondPairEnd; b++)
                {
                    for (int unprime = 2; unprime <= 7; unprime++)
                    {
                        if (a % unprime == 0 || b % unprime == 0)
                        {
                            break;
                        }
                        if (a % unprime != 0 || b % unprime != 0)
                        {
                            if (unprime == 7)
                            {
                                isPrime = true;
                            }
                            continue; 
                        }             
                    }
                    if (isPrime) 
                    {
                        Console.WriteLine($"{a}{b} ");
                    }
                    isPrime= false;
                }
            }
        }
    }
}

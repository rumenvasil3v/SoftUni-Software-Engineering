using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int specialOrNot = 1; specialOrNot <= n; specialOrNot++)
            {
                int numberPerIteration = specialOrNot;
                int sumOfDigits = 0;

                while (numberPerIteration > 0)
                {
                    sumOfDigits += numberPerIteration % 10;
                    numberPerIteration /= 10;
                }

                switch (sumOfDigits)
                {
                    case 5:
                    case 7:
                    case 11:
                        Console.WriteLine($"{specialOrNot} -> True");
                        break;
                    default:
                        Console.WriteLine($"{specialOrNot} -> False");
                        break;
                }
            }
        }
    }
}

using System;

namespace _11._Odd_Or_Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxNum = int.MinValue;
            double minNum = int.MaxValue;

            double evenMax = int.MinValue;
            double evenMin = int.MaxValue;
            
            double oddSum = 0;
            double evenSum = 0;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                if (i % 2 == 1)
                {
                    oddSum += number;
                    
                    if (number > maxNum)
                    {
                        maxNum = number;
                    }
                    if (number < minNum)
                    {
                        minNum = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (maxNum == int.MinValue && minNum == int.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minNum:f2},");
                Console.WriteLine($"OddMax={maxNum:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMax == int.MinValue && evenMin == int.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            
        }
    }
}

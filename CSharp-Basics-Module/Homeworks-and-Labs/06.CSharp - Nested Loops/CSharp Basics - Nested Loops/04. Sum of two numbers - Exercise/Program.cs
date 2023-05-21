using System;

namespace _04._Sum_of_two_numbers___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool isValid = false;
            int combination = 0;

            for (int x1 = start; x1 <= end; x1++)
            {
                for (int x2 = start; x2 <= end; x2++)
                {
                    combination++;
                    if (x1 + x2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({x1} + {x2} = {magicNumber})");
                        isValid = true;
                        break;
                    }
  
                }
                if (isValid)
                {
                    break;
                }
            }

            if (!isValid)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}

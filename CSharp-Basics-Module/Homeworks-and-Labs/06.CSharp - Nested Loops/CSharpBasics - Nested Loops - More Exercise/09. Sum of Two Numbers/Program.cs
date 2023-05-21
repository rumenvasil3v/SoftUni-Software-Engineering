using System;

namespace _09._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            bool isFound = false;
            int combinations = 0;
            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    combinations++;
                    if (a + b == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({a} + {b} = {magicNum})");
                        isFound = true;
                        break;

                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}

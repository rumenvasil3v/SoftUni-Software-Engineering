using System;

namespace _04._PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startOfSequence = int.Parse(Console.ReadLine());
            int endOfSequence = int.Parse(Console.ReadLine());

            int totalSumOfNumbers = 0;

            for (int i = startOfSequence; i <= endOfSequence; i++)
            {
                totalSumOfNumbers = totalSumOfNumbers + i;
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {totalSumOfNumbers}");
        }
    }
}

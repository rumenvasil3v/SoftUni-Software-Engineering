using System;

namespace _11._MultiTab_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondMultiplier = int.Parse(Console.ReadLine());

            for (int secondNum = secondMultiplier; secondNum <= 10; secondNum++)
            {
                Console.WriteLine($"{number} X {secondNum} = {number * secondNum}");
            }

            if (secondMultiplier > 10)
            {
                Console.WriteLine($"{number} X {secondMultiplier} = {number * secondMultiplier}");
            }

        }
    }
}

using System;

namespace _10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coinsOneLev = int.Parse(Console.ReadLine());
            int coinsTwoLev = int.Parse(Console.ReadLine());
            int banknotesFiveLev = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int a = 0; a <= coinsOneLev; a++)
            {
                for (int b = 0; b <= coinsTwoLev; b++)
                {
                    for (int c = 0; c <= banknotesFiveLev; c++)
                    {
                        if ((a * 1) + (b * 2) + (c * 5) == sum)
                        {
                            Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}

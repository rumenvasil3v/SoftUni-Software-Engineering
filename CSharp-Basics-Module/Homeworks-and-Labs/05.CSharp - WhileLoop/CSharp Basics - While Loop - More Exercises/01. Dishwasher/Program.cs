using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numBottles = int.Parse(Console.ReadLine());
            int bottle = numBottles * 750;
            int plate = 0;
            int saucePan = 0;
            int vessels = 0;
            string input;
            
            int countVessels = 1;

            while ((input = Console.ReadLine()) != "End")
            {
                vessels = int.Parse(input);
                if (countVessels % 3 == 0)
                {
                    saucePan += vessels;
                    bottle = bottle - vessels * 15;
                }
                else
                {
                    plate += vessels;
                    bottle = bottle - vessels * 5;
                }

                if (bottle < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(bottle)} ml. more necessary!");
                    break;
                }
                countVessels++;
            }

            if (bottle >= 0)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{plate} dishes and {saucePan} pots were washed.");
                Console.WriteLine($"Leftover detergent {bottle} ml.");
            }
        }
    }
}

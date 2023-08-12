using System;
using System.Linq;

namespace Problem_3___Hearth_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] neighborhood = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries);
            int[] houses = neighborhood.Select(int.Parse).ToArray();
            int cupidStart = 0;

            int countHouse = 0;
            string input;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] arguments = input.Split();
                int jumpLength = int.Parse(arguments[1]);
                cupidStart = cupidStart + jumpLength;
                
                if (cupidStart >= neighborhood.Length)
                {
                    cupidStart = 0;
                }

                if (houses[cupidStart] == 0)
                {
                    Console.WriteLine($"Place {cupidStart} already had Valentine's day.");
                    continue;
                }

                houses[cupidStart] -= 2;
                if (houses[cupidStart] == 0)
                {
                    Console.WriteLine($"Place {cupidStart} has Valentine's day.");
                    countHouse++;
                }
            }

            Console.WriteLine($"Cupid's last position was {cupidStart}.");

            if (countHouse == neighborhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Length - countHouse} places.");
            }
        }
    }
}
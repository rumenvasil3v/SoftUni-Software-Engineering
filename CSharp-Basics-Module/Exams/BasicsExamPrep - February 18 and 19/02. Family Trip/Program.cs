using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litersGas = double.Parse(Console.ReadLine());
            string dayOfWeekend = Console.ReadLine();

            double gasPrice = litersGas * 2.10;
            
            double finalPrice = gasPrice + 100;

            if (dayOfWeekend == "Saturday")
            {
                finalPrice *= 0.9;
            }
            else
            {
                finalPrice *= 0.8;
            }

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {budget - finalPrice:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {finalPrice - budget:F2} lv.");
            }
        }
    }
}

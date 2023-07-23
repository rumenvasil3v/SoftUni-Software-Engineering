using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            double percentCost = double.Parse(Console.ReadLine()) / 100;

            if (nights > 7)
            {
                priceNight = priceNight - priceNight * 0.05;
            }

            double nightsSum = nights * priceNight;
            double budgetCost = budget * percentCost;

            double budgetSum = nightsSum + budgetCost;
            
            if (budgetSum <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - budgetSum:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{budgetSum - budget:F2} leva needed.");
            }
        }
    }
}

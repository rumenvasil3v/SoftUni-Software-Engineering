using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            int people = int.Parse(Console.ReadLine());
            double entrance = double.Parse(Console.ReadLine());
            double priceLounger = double.Parse(Console.ReadLine());
            double priceUmbrella = double.Parse(Console.ReadLine());

            // Actions
            double entrancePrice = people * entrance;
            double umbrellas = Math.Ceiling(people * 0.5);
            umbrellas = umbrellas * priceUmbrella;
            double loungers = Math.Ceiling(people * 0.75);
            loungers = loungers * priceLounger;

            double totalSum = entrancePrice + loungers + umbrellas;
            
            // Output
            Console.WriteLine($"{totalSum:F2} lv.");
        }
    }
}

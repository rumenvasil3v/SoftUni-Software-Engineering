using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console budget, "VIP" or "Normal" and number of the people in the group.
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            double transportPrice = 0;

            if (numberOfPeople <= 4)
            {
                transportPrice =  budget - budget * 0.75;
            }
            else if (numberOfPeople <= 9)
            {
                transportPrice = budget - budget * 0.6;
            }
            else if (numberOfPeople <= 24)
            {
                transportPrice = budget - budget * 0.5;
            }
            else if (numberOfPeople <= 49)
            {
                transportPrice = budget - budget * 0.4;
            }
            else
            {
                transportPrice = budget - budget * 0.25;
            }

            if (category == "VIP")
            {
                double priceVip = 499.99 * numberOfPeople;
                if (transportPrice >= priceVip)
                {
                    Console.WriteLine($"Yes! You have {transportPrice - priceVip:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {priceVip - transportPrice:f2} leva.");
                }
            }
            else
            {
                double priceNormal = 249.99 * numberOfPeople;
                if (transportPrice >= priceNormal)
                {
                    Console.WriteLine($"Yes! You have {transportPrice - priceNormal:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {priceNormal - transportPrice:f2} leva.");
                }
            }
        }
    }
}

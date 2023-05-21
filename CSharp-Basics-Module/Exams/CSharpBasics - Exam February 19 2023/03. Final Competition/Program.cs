using System;

namespace _03._Final_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double moneyPrize = 0;

            if (place == "Bulgaria")
            {
                moneyPrize = points * numberDancers;
                if (season == "summer")
                {
                    moneyPrize *= 0.95;
                }
                else
                {
                    moneyPrize *= 0.92;
                }
            }
            else
            {
                moneyPrize = numberDancers * points;
                moneyPrize += moneyPrize * 0.5;
                if (season == "summer")
                {
                    moneyPrize *= 0.9;
                }
                else
                {
                    moneyPrize *= 0.85;
                }
            }

            double charitySum = moneyPrize * 0.75;
            double leftedMoney = charitySum - moneyPrize;
            Console.WriteLine($"Charity - {charitySum:F2}");
            Console.WriteLine($"Money per dancer - {Math.Abs(leftedMoney / numberDancers):F2}");
        }
    }
}

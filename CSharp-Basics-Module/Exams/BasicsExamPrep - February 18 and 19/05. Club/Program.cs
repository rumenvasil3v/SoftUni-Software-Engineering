using System;

namespace _05._Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double desireProfit = double.Parse(Console.ReadLine());

            double totalIncome = 0;
            double cocktailPrice = 0;
            string cocktail = Console.ReadLine();
            while (cocktail != "Party!")
            {
                int numberOfCocktails = int.Parse(Console.ReadLine());

                cocktailPrice = cocktail.Length;
                cocktailPrice = cocktailPrice * numberOfCocktails;
                
                if (cocktailPrice % 2 != 0)
                {
                    cocktailPrice *= 0.75;
                }
                else
                {
                    cocktailPrice = cocktailPrice;
                }

                totalIncome += cocktailPrice;

                if (totalIncome >= desireProfit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {totalIncome:F2} leva.");
                    break;
                }
                cocktail = Console.ReadLine();
            }

            if (cocktail == "Party!")
            {
                Console.WriteLine($"We need {Math.Abs(totalIncome - desireProfit):F2} leva more.");
                Console.WriteLine($"Club income - {totalIncome:F2} leva.");
            }
        }
    }
}

namespace _01._Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            decimal totalProfit = 0.0m;

            for (int i = 1; i <= numberOfCities; i++)
            {
                decimal profit = 0.0m;

                string nameOfCity = Console.ReadLine();
                decimal moneyEarned = decimal.Parse(Console.ReadLine());
                decimal ownerExpenses = decimal.Parse(Console.ReadLine());

                if (i % 3 == 0 && i % 5 == 0)
                {
                    totalProfit = EveryFifthCity(nameOfCity, moneyEarned, ownerExpenses, profit, totalProfit);
                }
                else if (i % 3 == 0)
                {
                    totalProfit = EveryThirdCity(nameOfCity, moneyEarned, ownerExpenses, totalProfit, profit);
                }
                else if (i % 5 == 0)
                {
                    totalProfit = EveryFifthCity(nameOfCity, moneyEarned, ownerExpenses, profit, totalProfit);
                }
                else
                {
                    totalProfit = TheOtherCities(nameOfCity, moneyEarned, ownerExpenses, profit, totalProfit);
                }
            }

            PrintTotalProfit(totalProfit);
        }

        static decimal EveryThirdCity(string nameOfCity, decimal moneyEarned, decimal ownerExpenses, decimal totalProfit, decimal profit)
        {
            ownerExpenses += ownerExpenses * 0.5m;
            profit = moneyEarned - ownerExpenses;
            totalProfit += profit;
            Console.WriteLine($"In {nameOfCity} Burger Bus earned {profit:f2} leva.");
            return totalProfit;
        }
        
        static decimal EveryFifthCity(string nameOfCity, decimal moneyEarned, decimal ownerExpenses, decimal profit, decimal totalProfit)
        {
            profit = moneyEarned * 0.9m - ownerExpenses;
            totalProfit += profit;
            Console.WriteLine($"In {nameOfCity} Burger Bus earned {profit:f2} leva.");
            return totalProfit;
        }
        
        static decimal TheOtherCities(string nameOfCity, decimal moneyEarned, decimal ownerExpenses, decimal profit, decimal totalProfit)
        {
            profit = moneyEarned - ownerExpenses;
            totalProfit += profit;
            Console.WriteLine($"In {nameOfCity} Burger Bus earned {profit:f2} leva.");
            return totalProfit;
        }
        
        static void PrintTotalProfit(decimal totalProfit)
        {
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
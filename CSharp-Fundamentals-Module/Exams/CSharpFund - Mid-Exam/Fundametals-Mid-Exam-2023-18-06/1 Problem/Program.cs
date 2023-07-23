/*
3
Sofia
895.67
213.50
Plovdiv
2563.20
890.26
Burgas
2360.55
600.00

5
Lille
2226.00
1200.60
Rennes
6320.60
5460.20
Reims
600.20
452.32
Bordeaux
6925.30
2650.40
Montpellier
680.50
290.20

15
Rom
550
230
Sofia
990
880
Burgas
1200
300
V. Tarnovo
2000
2000
Kiten
120
30
Chicago
320
150
California
1230
400
Varna
1233
432.45
Plovdiv
320
123.334
Gorna
432
123
Pazardzhik
1234.4
900
Qmbol
1378
456
Ruse
466.78
322
Montana
124.4
123
Balchik
1678.45
424.34
Burger Bus total profit: 5433.02 leva.
 */
namespace _1_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());

            decimal totalProfit = 0.0m;

            for (int i = 1; i <= numberOfCities; i++)
            {
                decimal profit;

                string nameOfCity = Console.ReadLine();
                decimal moneyEarned = decimal.Parse(Console.ReadLine());
                decimal ownerExpenses = decimal.Parse(Console.ReadLine());

                if (i % 3 == 0 && i % 5 == 0)
                {
                    moneyEarned *= 0.9m;
                    profit = moneyEarned - ownerExpenses;
                    totalProfit += profit;
                    Console.WriteLine($"In {nameOfCity} Burger Bus earned {profit:f2} leva.");
                    continue;
                }

                if (i % 3 == 0)
                {
                    ownerExpenses += ownerExpenses * 0.5m;
                    profit = moneyEarned - ownerExpenses;
                }
                else if (i % 5 == 0)
                {
                    profit = moneyEarned * 0.9m - ownerExpenses;
                }
                else
                {
                    profit = moneyEarned - ownerExpenses;
                }

                totalProfit += profit;
                Console.WriteLine($"In {nameOfCity} Burger Bus earned {profit:f2} leva.");
                profit = 0;
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
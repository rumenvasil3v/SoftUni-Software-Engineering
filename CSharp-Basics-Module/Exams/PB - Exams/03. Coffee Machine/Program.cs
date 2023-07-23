using System;

namespace _03._Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numDrinks = int.Parse(Console.ReadLine());

            double sum = 0;

            if (drink == "Espresso")
            {
                if (sugar == "Without")
                {
                    sum = numDrinks * 0.9;
                    sum = sum - sum * 0.35;
                }
                else if (sugar == "Normal")
                {
                    sum = numDrinks * 1;
                }
                else
                {
                    sum = numDrinks * 1.20;
                }

                if (numDrinks >= 5)
                {
                    sum = sum - sum * 0.25;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    sum = numDrinks * 1;
                    sum = sum - sum * 0.35;
                }
                else if (sugar == "Normal")
                {
                    sum = numDrinks * 1.20;
                }
                else
                {
                    sum = numDrinks * 1.60;
                }
            } 
            else
            {
                if (sugar == "Without")
                {
                    sum = numDrinks * 0.5;
                    sum = sum - sum * 0.35;
                }
                else if (sugar == "Normal")
                {
                    sum = numDrinks * 0.6;
                }
                else
                {
                    sum = numDrinks * 0.70;
                }
            }

            if (sum > 15)
            {
                sum = sum - sum * 0.2;
            }

            Console.WriteLine($"You bought {numDrinks} cups of {drink} for {sum:f2} lv.");
        }
    }
}

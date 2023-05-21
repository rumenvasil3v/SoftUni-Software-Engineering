using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Make variables for type of flower, number of flowers and budget.
            string flower = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double sum = 0;

            if (flower == "Roses")
            {
                if (number > 80)
                {
                    sum = number * 5;
                    sum = sum - sum * 0.1;
                }
                else
                {
                    sum = number * 5;
                }
            }
            else if (flower == "Dahlias")
            {
                if (number > 90)
                {
                    sum = number * 3.80;
                    sum = sum - sum * 0.15;
                }
                else
                {
                    sum = number * 3.80;
                }
            }
            else if (flower == "Tulips")
            {
                if (number > 80)
                {
                    sum = number * 2.80;
                    sum = sum - sum * 0.15;
                }
                else
                {
                    sum = number * 2.80;
                }
            }
            else if (flower == "Narcissus")
            {
                if (number < 120)
                {
                    sum = number * 3;
                    sum = sum + sum * 0.15;
                }
                else
                {
                    sum = number * 3;
                }
            }
            else
            {
                if (number < 80)
                {
                    sum = number * 2.50;
                    sum = sum + sum * 0.2;
                }
                else
                {
                    sum = number * 2.50;
                }
            }
            
            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flower} and {budget - sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
            }
        }
    }
}

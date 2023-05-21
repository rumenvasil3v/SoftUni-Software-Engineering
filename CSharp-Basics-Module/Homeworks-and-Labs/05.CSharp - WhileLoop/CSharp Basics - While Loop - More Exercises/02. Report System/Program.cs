using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int willingMoney = int.Parse(Console.ReadLine());

            string input;
            double cashPay = 0;
            double cardPay = 0;
            int countPay = 1;
            int countCash = 0;
            int countCard = 0;

            int amount = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int price = int.Parse(input);
                if (price > 100)
                {
                    if (countPay % 2 == 1)
                    {
                        Console.WriteLine("Error in transaction!");
                        countPay++;
                        continue;
                    }
                    else
                    {
                        cardPay += price;
                        countPay++;
                        countCard++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else if (price < 10)
                {
                    if (countPay % 2 == 0)
                    {
                        Console.WriteLine("Error in transaction!");
                        countPay++;
                        continue;
                    }
                    else
                    {
                        cashPay += price;
                        countPay++;
                        countCash++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (countPay % 2 == 1)
                    {
                        cashPay += price;
                        countPay++;
                        countCash++;
                        Console.WriteLine("Product sold!");
                    } 
                    else
                    {
                        cardPay += price;
                        countPay++;
                        countCard++;
                        Console.WriteLine("Product sold!");
                    }
                }
                amount += price;
                if (amount >= willingMoney)
                {
                    Console.WriteLine($"Average CS: {cashPay / countCash:f2}");
                    Console.WriteLine($"Average CC: {cardPay / countCard:f2}");
                    break;
                }
            }

            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}

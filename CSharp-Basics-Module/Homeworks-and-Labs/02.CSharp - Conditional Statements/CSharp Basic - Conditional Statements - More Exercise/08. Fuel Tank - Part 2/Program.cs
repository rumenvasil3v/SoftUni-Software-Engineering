
using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double quantityFuel = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();
            
            double moneyNeeded = 0;

            if (fuelType == "Gasoline")
            {
                if (discountCard == "Yes")
                {
                    moneyNeeded = 2.04 * quantityFuel;
                }

                else if (discountCard == "No")
                {
                    moneyNeeded = 2.22 * quantityFuel;
                }
            }

            else if (fuelType == "Diesel")
            {
                if (discountCard == "Yes")
                {
                    moneyNeeded = 2.21 * quantityFuel;
                }

                else if (discountCard == "No")
                {
                    moneyNeeded = 2.33 * quantityFuel;
                }
            }

            else if (fuelType == "Gas")
            {
                if (discountCard == "Yes")
                {
                    moneyNeeded = 0.85 * quantityFuel;
                }

                else if (discountCard == "No")
                {
                    moneyNeeded = 0.93 * quantityFuel;
                }
            }

            if (quantityFuel >= 20 && quantityFuel <= 25)
            {
                moneyNeeded *= 0.92;
            }

            else if (quantityFuel > 25)
            {
                moneyNeeded = moneyNeeded * 0.9;
            }

            Console.WriteLine($"{moneyNeeded:f2} lv.");
        }
    }
}

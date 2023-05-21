using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Input
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //2. Actions
            double price = 0;
            if (town == "Sofia")
            {
                //Prices for Sofia
                if (product == "coffee")
                {
                    price = 0.5;
                }
                else if (product == "water")
                {
                    price = 0.8;
                }
                else if (product == "beer")
                {
                    price = 1.20;
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                }
                else if (product == "peanuts")
                {
                    price = 1.60;
                }
            }
            else if (town == "Plovdiv")
            {
                //Prices for Plovdiv
                if (product == "coffee")
                {
                    price = 0.4;
                }
                else if (product == "water")
                {
                    price = 0.7;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    price = 1.3;
                }
                else if (product == "peanuts")
                {
                    price = 1.50;
                }

            }
            else if (town == "Varna")
            {
                //Prices for Varna
                if (product == "coffee")
                {
                    price = 0.45;
                }
                else if (product == "water")
                {
                    price = 0.7;
                }
                else if (product == "beer")
                {
                    price = 1.1;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                }
            }
            double totalPrice = quantity * price;
            //3. Output -> Price
            Console.WriteLine(totalPrice);
        }
    }
}

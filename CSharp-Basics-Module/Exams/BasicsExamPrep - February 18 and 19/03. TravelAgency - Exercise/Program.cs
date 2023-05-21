using System;

namespace _03._TravelAgency___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
           
            if (days <= 0)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                // logic of the program with valid data
                double pricePerDay = 0;
                double discount = 0;

                if (town == "Bansko" || town == "Borovets")
                { 
                    if (package == "withEquipment")
                    {
                        pricePerDay = 100;
                        discount = 0.10;
                    }
                    else if (package == "noEquipment")
                    {
                        pricePerDay = 80;
                        discount = 0.5;
                    }
                }
                else if (town == "Varna" || town == "Burgas")
                {
                    if (package == "withBreakfast")
                    {
                        pricePerDay = 130;
                        discount = 0.12;
                    }
                    else if (package == "noBreakfast")
                    {
                        pricePerDay = 100;
                        discount = 0.7;
                    }
                }

                if (pricePerDay== 0 && discount == 0)
                {
                    Console.WriteLine($"Invalid input!");
                }
                else
                {
                    if (vipDiscount == "yes")
                    {
                        pricePerDay -= pricePerDay * discount;
                    }

                    if (days > 7)
                    {
                        days--;
                    }
                    double totalPrice = days * pricePerDay;
                    Console.WriteLine($"The price is {totalPrice:F2}lv! Have a nice time!");

                }
            }
        }
    }
}

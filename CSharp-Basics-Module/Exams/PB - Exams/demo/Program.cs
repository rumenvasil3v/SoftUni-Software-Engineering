using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double sum = 0;

            if (days > 7)
            {
                days--;
            }

            if (town == "Bansko" || town == "Borovets")
            {
                if (package == "withEquipment")
                {
                    sum = days * 100;
                    if (vipDiscount == "yes")
                    {
                        sum = sum - sum * 0.1;
                    }
                }
                else
                {
                    sum = days * 80;
                    if (vipDiscount == "yes")
                    {
                        sum = sum - sum * 0.05;
                    }
                }

            }
            else
            {
                if (package == "withBreakfast")
                {
                    sum = days * 130;
                    if (vipDiscount == "yes")
                    {
                        sum = sum - sum * 0.12;
                    }
                }
                else
                {
                    sum = days * 100;
                    if (vipDiscount == "yes")
                    {
                        sum = sum - sum * 0.07;
                    }
                }

            }

            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (town != "Burgas" && town != "Varna" && town != "Bansko" && town != "Borovets")
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
            }
        }
    }
}



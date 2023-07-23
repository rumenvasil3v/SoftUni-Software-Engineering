using System;

namespace _03._Travel_Agency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            bool isValid = false;

            double sum = 0;

            if (days > 7)
            {
                days--;
            }

            if (town == "Bansko" || town == "Borovets")
            {
                if (package == "withEquipment")
                {
                    sum = 100;
                    if (vipDiscount == "yes")
                    {
                        sum = sum - sum * 0.1;
                    }
                }
                else if(package == "noEquipment")
                {
                    sum = 80;
                    if (vipDiscount == "yes")
                    {
                        sum = sum - sum * 0.05;
                    }
                    
                }
                else
                {
                    isValid= true;
                }
            }
            else if (town == "Varna" || town == "Burgas")
            {
                if (package == "withBreakfast")
                {
                    sum = 130;
                    if (vipDiscount == "yes")
                    {
                        sum = sum - sum * 0.12;
                    }
                    
                }
                else if (package == "noBreakfast")
                {
                    sum = 100;
                    if (vipDiscount == "yes")
                    {
                        sum = sum - sum * 0.07;
                    }
                    
                }
                else
                {
                    isValid= true;
                }
            }
            else
            {
                isValid = true;
            }
            

            if (isValid)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else 
            {
                sum = sum * days;
                Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
            }
        }
    }
}

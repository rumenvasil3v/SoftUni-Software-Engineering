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

            switch (vipDiscount) 
            {
                case "yes":
                    if (town == "Bansko" || town == "Borovets")
                    {
                        if (package == "withEquipment")
                        {
                            sum += 100;
                            sum *= 0.9;
                        }
                        else if (package == "noEquipment")
                        {
                            sum +=  80;
                            sum *= 0.95;
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
                            sum += 130;
                            sum *= 0.88;
                        }
                        else if (package == "noBreakfast")
                        {
                            sum += 100;
                            sum *= 0.93;
                        }
                        else
                        {
                            isValid= true;
                        }
                    }
                    else
                    {
                        isValid= true;
                    }
                    break;
                 case "no":
                    if (town == "Bansko" || town == "Borovets")
                    {
                        if (package == "withEquipment")
                        {
                            sum += 100;
                        }
                        else if (package == "noEquipment")
                        {
                            sum += 80;
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
                            sum += 130;
                        }
                        else if (package == "noBreakfast")
                        {
                            sum += 100;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                    else
                    {
                        isValid= true;
                    }
                    break;
            }
           
            if (isValid)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (days <= 0)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                Console.WriteLine($"The price is {sum * days:F2}lv! Have a nice time!");
            }
        }
    }
}

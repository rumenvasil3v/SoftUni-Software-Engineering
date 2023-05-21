using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console season and kilometers per month.
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());

            double price = 0;
            double seasonSum = 4 * km;
            
            if (km > 10000 && km <= 20000)
            {
                price = 1.45 * seasonSum;
            }
            else if (km > 5000 && km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    price = 0.95 * seasonSum;
                }
                else if (season == "Summer")
                {
                    price = 1.10 * seasonSum;
                }
                else
                {
                    price = 1.25 * seasonSum;
                }
            }
            else 
            {
                if (season == "Spring" || season == "Autumn")
                {
                    price = 0.75 * seasonSum;
                }
                else if (season == "Summer")
                {
                    price = 0.90 * seasonSum;
                }
                else
                {
                    price = 1.05 * seasonSum;
                }
            }

            price =  price  - price * 0.1;

            Console.WriteLine("{0:F2}", price);
        }
    }
}

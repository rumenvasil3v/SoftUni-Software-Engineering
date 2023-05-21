using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            daysToStay = daysToStay - 1;
            string room = Console.ReadLine();
            string rate = Console.ReadLine();

            double price = 0;

            if (room == "room for one person")
            {
                if (daysToStay < 10)
                {
                    price = daysToStay * 18.00;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    price = daysToStay * 18.00;
                }
                else
                {
                    price = daysToStay * 18.00;
                }
            }
            else if (room == "apartment")
            {
                if (daysToStay < 10)
                {
                    price = daysToStay * 25.00;
                    price -= price * 0.3;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    price = daysToStay * 25.00;
                    price -= price * 0.35;
                }
                else
                {
                    price = daysToStay * 25.00;
                    price -= price * 0.5;
                }
            }
            else
            {
                if (daysToStay < 10)
                {
                    price = daysToStay * 35.00;
                    price -= price * 0.1;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    price = daysToStay * 35.00;
                    price -= price * 0.15;
                }
                else
                {
                    price = daysToStay * 35.00;
                    price -= price * 0.2;
                }
            }

            if (rate == "positive")
            {
                price += price * 0.25;
            }
            else
            {
                price -= price * 0.1; 
            }

            Console.WriteLine("{0:F2}",price);
        }
    }
}

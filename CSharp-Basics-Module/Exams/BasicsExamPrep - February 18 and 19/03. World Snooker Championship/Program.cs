using System;

namespace _03._World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            int pricePic = 40;

            string championshipStage = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int bills = int.Parse(Console.ReadLine());
            char trophyPic = char.Parse(Console.ReadLine());

            switch (championshipStage)
            {
                case "Quarter final":
                    if (typeTicket == "Standard")
                    {
                        totalPrice = 55.50 * bills;
                    }
                    else if (typeTicket == "Premium")
                    {
                        totalPrice = 105.20 * bills;
                    }
                    else
                    {
                        totalPrice = 118.90 * bills;
                    }
                    break;
                case "Semi final":
                    if (typeTicket == "Standard")
                    {
                        totalPrice = 75.88 * bills;
                    }
                    else if (typeTicket == "Premium")
                    {
                        totalPrice = 125.22 * bills;
                    }
                    else
                    {
                        totalPrice = 300.40 * bills;
                    }
                    break;
                case "Final":
                    if (typeTicket == "Standard")
                    {
                        totalPrice = 110.10 * bills;
                    }
                    else if (typeTicket == "Premium")
                    {
                        totalPrice = 160.66 * bills;
                    }
                    else
                    {
                        totalPrice = 400 * bills;
                    }
                    break;
            }

            if (totalPrice > 2500 && totalPrice <= 4000)
            {
                totalPrice = totalPrice * 0.9;
            }

            if (totalPrice > 4000)
            {
                totalPrice = totalPrice * 0.75;
                pricePic = 0;
            }

            if (trophyPic == 'Y')
            {
                totalPrice = totalPrice + pricePic * bills;
            }
            Console.WriteLine("{0:0.00}",totalPrice);
        }
    }
}

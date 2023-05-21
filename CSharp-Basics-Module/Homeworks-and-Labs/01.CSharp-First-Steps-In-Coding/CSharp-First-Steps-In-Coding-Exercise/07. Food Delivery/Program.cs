using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());
            double delivery = 2.50;

            double chickenMenusPrice =  chickenMenus * 10.35;
            double fishMenusPrice = fishMenus * 12.40;
            double vegetarianMenusPrice = vegetarianMenus * 8.15;
            double menusBill = chickenMenusPrice + fishMenusPrice + vegetarianMenusPrice;
            double desertPrice = menusBill * 0.2;
            double totalBill = menusBill + desertPrice + delivery;
            Console.WriteLine(totalBill);
        }
    }
}

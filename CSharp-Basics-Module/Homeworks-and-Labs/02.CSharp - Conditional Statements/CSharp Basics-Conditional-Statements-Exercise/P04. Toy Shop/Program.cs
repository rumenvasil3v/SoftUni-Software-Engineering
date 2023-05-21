using System;

namespace P04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int plushyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int toyTrucks = int.Parse(Console.ReadLine());

            double puzzlesPrice = puzzles * 2.60;
            int dollsPrice = dolls * 3;
            double plushyBearsPrice = plushyBears * 4.10;
            double minionsPrice = minions * 8.20;
            int toyTrucksPrice = toyTrucks * 2;
            double totalSumToys = puzzlesPrice + dollsPrice + plushyBearsPrice + minionsPrice + toyTrucksPrice;
            double orderToys = puzzles + dolls + plushyBears + minions + toyTrucks;
            
            if (orderToys >= 50)
            {
                double discount = totalSumToys * 0.25;
                totalSumToys = totalSumToys - discount;
            }

            double rent = totalSumToys * 0.1;
            totalSumToys = totalSumToys - rent;
            
            if (totalSumToys >= tripPrice)
            {
                double leftMoney = totalSumToys - tripPrice;
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
                
            }
            else
            {
                double neededMoney = tripPrice- totalSumToys;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
                
            }
        }
    }
}

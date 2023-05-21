using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double musselsKg = double.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice * 0.6;
            bonitoPrice = mackerelPrice + mackerelPrice * 0.6;
            double bonitoSum = bonitoKg * bonitoPrice;

            double safridPrice = spratPrice * 0.8;
            safridPrice = spratPrice + spratPrice * 0.8;
            double safridSum = safridKg * safridPrice;

            double musselSum = musselsKg * 7.50;
            

            double needMoney = bonitoSum + safridSum + musselSum;
            Console.WriteLine("{0:F2}",needMoney);
        }
    }
}

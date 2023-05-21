using System;

namespace _11._HappyCat_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursForOneDay = int.Parse(Console.ReadLine());

            double parkingTax = 0;
            double totalSum = 0;

            for (int d = 1; d <= days; d++)
            {
                for (int h = 1; h <= hoursForOneDay; h++)
                {
                    if (d % 2 == 0 && h % 2 != 0)
                    {
                        parkingTax += 2.50;
                    }
                    else if (d % 2 != 0 && h % 2 == 0)
                    {
                        parkingTax += 1.25;
                    }
                    else
                    {
                        parkingTax += 1;
                    }
                }
                Console.WriteLine($"Day: {d} - {parkingTax:F2} leva");
                totalSum+= parkingTax;
                parkingTax = 0;
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}

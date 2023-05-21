using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chrysanthemums = int.Parse(Console.ReadLine());
            double roses = int.Parse(Console.ReadLine());
            double tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double boughtFlowers = chrysanthemums + roses + tulips;
            double totalSum = 0;

            if (season == "Spring" || season == "Summer")
            {
                totalSum = chrysanthemums * 2 + roses * 4.10 + tulips * 2.50;
                if (holiday == "Y")
                {
                    totalSum += totalSum * 0.15;
                }

                if (tulips > 7 && season == "Spring")
                {
                    totalSum -= totalSum * 0.05;
                }
                
            }
            else 
            {
                totalSum = chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15;
                if (holiday == "Y")
                {
                    totalSum += totalSum * 0.15;
                }

                if (roses >= 10 && season == "Winter")
                {
                    totalSum -= totalSum * 0.1;
                } 
            }

            if (boughtFlowers > 20)
            {
                totalSum -= totalSum * 0.2;
            }

            Console.WriteLine("{0:F2}",totalSum + 2);
        }
    }
}

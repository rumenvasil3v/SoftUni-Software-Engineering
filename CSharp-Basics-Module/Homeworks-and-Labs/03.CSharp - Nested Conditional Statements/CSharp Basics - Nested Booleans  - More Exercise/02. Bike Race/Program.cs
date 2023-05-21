using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorBikers = int.Parse(Console.ReadLine());
            int seniorBikers = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();

            double sum = 0;
            double competitors = juniorBikers + seniorBikers;

            if (track == "trail")
            {
                sum = juniorBikers * 5.50 + seniorBikers * 7;
            }
            else if (track == "cross-country")
            {
                if (competitors >= 50)
                {
                    sum = juniorBikers * 8 + seniorBikers * 9.50;
                    sum = sum - sum * 0.25;
                }
                else
                {
                    sum = juniorBikers * 8 + seniorBikers * 9.50;
                }
            }
            else if (track == "downhill")
            {
                sum = juniorBikers * 12.25 + seniorBikers * 13.75;
            }
            else
            {
                sum = juniorBikers * 20 + seniorBikers * 21.50;
            }

            sum = sum - sum * 0.05;

            Console.WriteLine("{0:F2}",sum);
        }
    }
}

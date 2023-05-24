using System;
using System.Threading;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalAmountOfSpice = 0;
            int days = 0;
            int workersConsume = 26;
            int spice = 0;

            while (startingYield >= 100)
            {
                spice = startingYield;
                
                spice = spice - workersConsume;
                totalAmountOfSpice += spice;

                startingYield -= 10;
                days++;
            }

            if (spice < workersConsume)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalAmountOfSpice);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(totalAmountOfSpice - workersConsume);
            }

        }
    }
}

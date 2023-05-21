using System;

namespace _09._Weather_Forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time1 = Console.ReadLine();

            if (time1 == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}

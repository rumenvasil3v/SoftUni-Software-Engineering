using System;

namespace P06._SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            if (speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}

using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenghtH = double.Parse(Console.ReadLine()) * 100;
            double widthW = double.Parse(Console.ReadLine()) * 100;
            double width = widthW - 100;

            int desksPerRow = (int)width / 70;
            int Rows = (int)lenghtH / 120;

            double workingPlaces = (desksPerRow * Rows) - 3 ;
            Console.WriteLine(workingPlaces);
        }
    }
}

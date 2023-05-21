using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double cleanersLitres = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()); 

            double penPrice = pen * 5.80;
            double markersPrice = markers * 7.20;
            double cleanersPrice = cleanersLitres * 1.20;
            double sum = penPrice + markersPrice + cleanersPrice;
            double sumDiscount = sum - sum * discount * 0.01;
           
            Console.WriteLine(sumDiscount);
        }
    }
}

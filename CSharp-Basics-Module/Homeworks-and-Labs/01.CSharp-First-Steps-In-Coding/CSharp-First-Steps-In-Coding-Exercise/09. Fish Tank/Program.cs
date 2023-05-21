using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage  = double.Parse(Console.ReadLine());
            

            int volumeAquarium = lenght * width * height;
            double volumeLitres = volumeAquarium * 0.001;
            double occupiedSpace = percentage / 100;
            double requiredLitres = volumeLitres * (1 - occupiedSpace);
            Console.WriteLine(requiredLitres);
        }
    }
}

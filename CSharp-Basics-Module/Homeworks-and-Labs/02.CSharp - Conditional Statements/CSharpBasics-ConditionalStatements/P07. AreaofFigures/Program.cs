using System;

namespace P07._AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string geometricFigure = Console.ReadLine();
            

            if (geometricFigure == "square")
            {
                double lenghtOfSquare = double.Parse(Console.ReadLine());
                double area = lenghtOfSquare * lenghtOfSquare;
                Console.WriteLine($"{area:f3}");
            }
            if (geometricFigure == "rectangle")
            {
                double lenghtA = double.Parse(Console.ReadLine());
                double lenghtB = double.Parse(Console.ReadLine());
                double area = lenghtA * lenghtB;
                Console.WriteLine($"{area:f3}");
            }
            if (geometricFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * (radius * radius);
                Console.WriteLine($"{area:f3}");
            }
            if (geometricFigure == "triangle")
            {
                double lenghtA = double.Parse(Console.ReadLine());
                double heightH = double.Parse(Console.ReadLine());
                double area = 0.5 * (lenghtA * heightH);
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}

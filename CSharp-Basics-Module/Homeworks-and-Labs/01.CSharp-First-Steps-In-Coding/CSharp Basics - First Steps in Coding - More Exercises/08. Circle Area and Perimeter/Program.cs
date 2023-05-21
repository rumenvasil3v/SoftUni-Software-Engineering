using System;

namespace _08._Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = (r * r) * Math.PI;
            Console.WriteLine("{0:F2}",circleArea);

            double circlePerimeter = 2 * Math.PI * r;
            Console.WriteLine("{0:F2}",circlePerimeter);
        }
    }
}

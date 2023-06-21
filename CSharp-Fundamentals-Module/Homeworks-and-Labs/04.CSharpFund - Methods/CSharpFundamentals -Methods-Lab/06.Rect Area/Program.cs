using System;

namespace _06.Rect_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int area = RectangleArea(sideA, sideB);
            Console.WriteLine(area);
        }

        static int RectangleArea(int width, int height)
        {
            return width * height;
        }
    }
}

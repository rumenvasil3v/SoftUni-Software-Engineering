using System;

internal class Program
{
    static void Main()
    {
        double lengthOfPyramid, widthOfPyramid, heightOfPyramid;
        Console.Write("Length: ");
        lengthOfPyramid = double.Parse(Console.ReadLine());

        Console.Write("Width: ");
        widthOfPyramid = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        heightOfPyramid = double.Parse(Console.ReadLine());

        double volume = (lengthOfPyramid * widthOfPyramid * heightOfPyramid) / 3;
        Console.WriteLine($"Pyramid Volume: {volume:f2}");
    }
}
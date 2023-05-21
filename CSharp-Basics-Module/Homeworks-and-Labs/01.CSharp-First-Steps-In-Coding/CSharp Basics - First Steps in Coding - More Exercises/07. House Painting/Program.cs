using System;

namespace _07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Разход за зелена боя (1 литър = 3.4 метра на квадрат)
            //2. Разход за червена боя (1 литър = 4.3 метра на квадрат)
            //3. Размери на стените
            //предната и задната страна са квадрати със страна "x") 

            //предната стена има правоъгълна врата с широчина 1.2 метра и височина 2 м

            //страничните страни са правоъгълници със страни "x" и "y"

            //и на двете стени има квадратен прозорец със страна  1.5 метра

            //5. Размери на покрива:
            // два правоъгълника със страни "х" и "y"
            // два равностранни триъгълника със страна "х" и височина "h"
            //6. Трябва да се пресметне площта на всички страни и площта на покрива, за да се 
            //намери колко литра от всяка боя ще са нужни
            
            double greeenPaint = 3.4;
            double redPaint = 4.3;

            double houseHeightX = double.Parse(Console.ReadLine());
            double lenghtSideWallY = double.Parse(Console.ReadLine());
            double triangleWallHeight = double.Parse(Console.ReadLine());

            double sideWallArea = houseHeightX * lenghtSideWallY;
            sideWallArea = 2 * sideWallArea - 2 * 2.25;
            double frontWallArea = houseHeightX * houseHeightX;
            frontWallArea = 2 * frontWallArea - 2.4;
            double totalArea = sideWallArea + frontWallArea;
            double greenPaintLitres = totalArea / greeenPaint;
            Console.WriteLine("{0:F2}",greenPaintLitres);

            double sideRoofArea = houseHeightX * lenghtSideWallY;
            sideRoofArea = 2 * sideRoofArea;
            double frontRoofTriangle = houseHeightX * triangleWallHeight / 2;
            frontRoofTriangle = 2 * frontRoofTriangle;
            double totalRoofArea = sideRoofArea + frontRoofTriangle;
            double redPaintLitres = totalRoofArea / redPaint;
            Console.WriteLine("{0:F2}", redPaintLitres);
        }
    }
}

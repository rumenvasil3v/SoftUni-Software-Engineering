using System;
using System.Collections.Generic;
/*
1024
768
 */

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Megapixels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widthOfImage = int.Parse(Console.ReadLine());
            int heightOfImage = int.Parse(Console.ReadLine());

            int imageResolution = widthOfImage * heightOfImage;

            double imageMegapixels = imageResolution / 1000000d;

            Console.WriteLine($"{widthOfImage}x{heightOfImage} => {Math.Round(imageMegapixels, 1)}MP");
            //Console.WriteLine($"{widthOfImage}x{heightOfImage} => {imageMegapixels}MP");
        }
    }
}

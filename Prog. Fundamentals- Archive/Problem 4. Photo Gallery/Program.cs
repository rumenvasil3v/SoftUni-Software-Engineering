using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Photo_Gallery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentTakenPhoto = int.Parse(Console.ReadLine());

            int dayPhotoWasTaken = int.Parse(Console.ReadLine());
            int monthPhotoWasTaken = int.Parse(Console.ReadLine());
            int yearPhotoWasTaken = int.Parse(Console.ReadLine());

            int hourPhotoWasTaken = int.Parse(Console.ReadLine());
            int minutesPhotoWasTaken = int.Parse(Console.ReadLine());

            double photoSizeInBytes = double.Parse(Console.ReadLine());

            int widthOfPhoto = int.Parse(Console.ReadLine());
            int heightOfPhoto = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{currentTakenPhoto:D4}.jpg");
            Console.WriteLine($"Date Taken: {dayPhotoWasTaken:d2}/{monthPhotoWasTaken:d2}/{yearPhotoWasTaken} {hourPhotoWasTaken:d2}:{minutesPhotoWasTaken:d2}");

            string unit = "MB";
            double size = photoSizeInBytes / 1000000;

            if (photoSizeInBytes / 1000000 < 1)
            {
                if (photoSizeInBytes / 1000 < 1)
                {
                    size = photoSizeInBytes;
                    unit = "B";
                }
                else
                {
                    size = photoSizeInBytes / 1000;
                    unit = "KB";
                }
            }
            Console.WriteLine($"Size: {size}{unit}");

            string photoOrientation = string.Empty;

            if (widthOfPhoto > heightOfPhoto)
            {
                photoOrientation = "landscape";
            }
            else if (widthOfPhoto < heightOfPhoto)
            {
                photoOrientation = "portrait";
            }
            else
            {
                photoOrientation = "square";
            }

            Console.WriteLine($"Resolution: {widthOfPhoto}x{heightOfPhoto} ({photoOrientation})");
        }
    }
}

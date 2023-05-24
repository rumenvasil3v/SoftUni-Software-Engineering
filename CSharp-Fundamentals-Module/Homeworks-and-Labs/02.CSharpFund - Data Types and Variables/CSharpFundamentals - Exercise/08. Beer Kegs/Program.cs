using System;
/*
 3
Keg 1
10
10
Keg 2
20
20
Keg 3
10
30

2
Smaller Keg
2.41
10
Bigger Keg
5.12
20
 */
namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string biggestModelKeg = string.Empty;
            double biggestKeg = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                string modelOfKeg = Console.ReadLine();
                float radiusOfKeg = float.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());

                float volumeOfKeg = (float)(Math.PI * (radiusOfKeg * radiusOfKeg) * heightOfKeg);
                if (volumeOfKeg > biggestKeg)
                {
                    biggestKeg = volumeOfKeg;
                    biggestModelKeg = modelOfKeg;
                }
            }

            Console.WriteLine(biggestModelKeg);
        }
    }
}

using System;
/*
 int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int originalvalueofn = n;

            n -= m;

            if (n == originalvalueofn * 0.5)
            {
                if (n % y > 0)
                {
                    n /= y;
                }

            }

int n2 = 2_000_000_000;
            int n3 = int.maxvalue;

            int a = 13;
            uint sum = a * 0.5;
            console.writeline(sum);

42
7
3

 */
namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());

            int snowballValue = 0;
            int highestQualitySnowball = 0;

            ushort snowballSnow = ushort.Parse(Console.ReadLine());
            ushort snowballTime = ushort.Parse(Console.ReadLine());
            byte snowballQuality = byte.Parse(Console.ReadLine());

            snowballValue = (snowballSnow / snowballTime);
            int snowballVal = snowballValue;
            for (int i = 1; i < snowballQuality; i++)
            {
                
                snowballValue *= snowballVal;
            }
            Console.WriteLine(snowballValue);
        }
    }
}

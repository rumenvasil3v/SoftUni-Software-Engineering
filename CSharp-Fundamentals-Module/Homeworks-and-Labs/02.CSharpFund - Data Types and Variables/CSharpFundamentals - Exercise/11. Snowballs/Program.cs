using System;
using System.Numerics;
/*
2
10
2
3
5
5
5

3
10
5
7
16
4
2
20
2
2

2
28
4
5

*/
namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());

            short highestSnowball = 0;
            short highestSnowballTime = 0;
            BigInteger highestSnowballValue = 0;
            byte highestSnowballQuality = 0;

            for (byte i = 0; i < numberOfSnowballs; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballQuality = snowballQuality;
                    highestSnowballValue = snowballValue;
                    highestSnowballTime = snowballTime;
                    highestSnowball = snowballSnow;
                }
            }

            Console.WriteLine($@"{highestSnowball} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuality})");
        }
    }
}
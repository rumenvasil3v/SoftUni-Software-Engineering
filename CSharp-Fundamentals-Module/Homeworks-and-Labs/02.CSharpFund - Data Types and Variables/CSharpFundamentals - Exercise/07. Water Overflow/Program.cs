using System;
/*
 5
20
100
100
100
20

 1
1000

7
10
20
30
10
5
10
20

4
250
10
20
40
 */
namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            short capacityOfWaterTank = 255;
            short litersInTank = 0;

            for (int i = 1; i <= n; i++)
            {
                ushort litersToPour = ushort.Parse(Console.ReadLine());
                capacityOfWaterTank -= (short)litersToPour;

                if (capacityOfWaterTank < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacityOfWaterTank += (short)litersToPour;
                    continue;
                }
                else
                {
                    litersInTank += (short)litersToPour;
                }
            }

            Console.WriteLine(litersInTank);
        }
    }
}

using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameMoves = int.Parse(Console.ReadLine());

            double intervalSum = 0;
            double percent1 = 0;
            double percent2 = 0;
            double percent3 = 0;
            double percent4 = 0;
            double percent5 = 0;
            double percent6 = 0;

            for (int i = 1; i <= gameMoves; i++)
            {
                int numInterval = int.Parse(Console.ReadLine());

                if (numInterval >= 0 && numInterval <= 9)
                {
                    percent1++;
                    intervalSum = intervalSum + numInterval * 0.2;
                }
                else if (numInterval >= 10 && numInterval <= 19)
                {
                    percent2++;
                    intervalSum = intervalSum + numInterval * 0.3;
                }
                else if (numInterval >= 20 && numInterval <= 29)
                {
                    percent3++;
                    intervalSum = intervalSum + numInterval * 0.4;
                }
                else if (numInterval >= 30 && numInterval <= 39)
                {
                    percent4++;
                    intervalSum = intervalSum + 50;
                }
                else if (numInterval >= 40 && numInterval <= 50)
                {
                    percent5++;
                    intervalSum += 100;
                }
                else
                {
                    percent6++;
                    intervalSum = intervalSum / 2;
                }
            }

            Console.WriteLine("{0:F2}",intervalSum);
            Console.WriteLine($"From 0 to 9: {percent1 / gameMoves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {percent2 / gameMoves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {percent3 / gameMoves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {percent4 / gameMoves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {percent5 / gameMoves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {percent6 / gameMoves * 100:f2}%");
        }
    }
}

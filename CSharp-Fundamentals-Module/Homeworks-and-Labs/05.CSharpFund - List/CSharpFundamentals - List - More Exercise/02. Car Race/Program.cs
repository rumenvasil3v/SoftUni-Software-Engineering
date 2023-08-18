/*
0 0 3 4 10 20 1 0 9 8 7
 */

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            decimal leftRacerTime = 0;

            for (int r1 = 0; r1 < numbers.Count / 2; r1++)
            {
                if (numbers[r1] == 0)
                {
                    leftRacerTime *= 0.8m;
                    continue;
                }

                leftRacerTime += numbers[r1];
            }

            decimal rightRacerTime = 0;

            for (int r2 = numbers.Count - 1; r2 > numbers.Count / 2; r2--)
            {
                if (numbers[r2] == 0)
                {
                    rightRacerTime *= 0.8m;
                    continue;
                }

                rightRacerTime += numbers[r2];
            }

            string winnerOfTheRace = string.Empty;
            double winnerTotalTime = 0;

            if (leftRacerTime > rightRacerTime)
            {
                winnerOfTheRace = "right";
                winnerTotalTime = (double)rightRacerTime;
            }
            else if (rightRacerTime > leftRacerTime)
            {
                winnerOfTheRace = "left";
                winnerTotalTime = (double)leftRacerTime;
            }

            Console.WriteLine($"The winner is {winnerOfTheRace} with total time: {winnerTotalTime}");
        }
    }
}
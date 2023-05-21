using System;

namespace _05._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int competitions = int.Parse(Console.ReadLine());
            int startUpPoints = int.Parse(Console.ReadLine());

            int wins = 0;
            int totalPoints = 0;

            for (int i = 1; i <= competitions; i++)
            {
                string competitionStage = Console.ReadLine();

                switch (competitionStage)
                {
                    case "W":
                        totalPoints += 2000;
                        wins++;
                        break;
                    case "F":
                        totalPoints += 1200;
                        break;
                    case "SF":
                        totalPoints += 720;
                        break;
                }
            }
            double averagePoints = (double)totalPoints / competitions;
            double percentageWon = (wins * 1.0) / competitions * 100;

            totalPoints += startUpPoints;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentageWon:F2}%");
        }
    }
}

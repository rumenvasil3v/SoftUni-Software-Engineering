using System;

namespace _06._Basketball_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int wins = 0;
            int losses = 0;
            int totalGames = 0;

            while (input != "End of tournaments")
            {
                string nameOfTournamet = input;

                int gamesPerTournament = int.Parse(Console.ReadLine());
                totalGames += gamesPerTournament;
                for (int i = 1; i <= gamesPerTournament; i++)
                {
                    int pointsTeamDesi = int.Parse(Console.ReadLine());
                    int pointsOpponents = int.Parse(Console.ReadLine());

                    if (pointsTeamDesi > pointsOpponents)
                    {
                        Console.WriteLine($"Game {i} of tournament {nameOfTournamet}: win with " +
                            $"{pointsTeamDesi - pointsOpponents} points.");
                        wins++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {nameOfTournamet}: lost with" +
                            $" {pointsOpponents - pointsTeamDesi} points.");
                        losses++;
                    }
                }
                input= Console.ReadLine();
            }

            double percentageWins = wins * 1.0 / totalGames * 100;
            double percentageLosses = (double)losses / totalGames * 100;

            Console.WriteLine($"{percentageWins:f2}% matches win");
            Console.WriteLine($"{percentageLosses:f2}% matches lost");
        }
    }
}

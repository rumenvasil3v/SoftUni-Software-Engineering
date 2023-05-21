using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int competitions = int.Parse(Console.ReadLine());
            int starterPoints = int.Parse(Console.ReadLine());

            int semiFinals = 720;
            int finalPoints = 1200;
            int winPoints = 2000;

            int wins = 0;
            int finals = 0;
            int sf = 0;
            int competitionsPoint = 0 + starterPoints;


            for (int i = 1; i <= competitions; i++)
            {
                string competitionPlace = Console.ReadLine();
                if (competitionPlace == "W")
                {
                    competitionsPoint = competitionsPoint + 2000;
                    wins++;
                }
                else if (competitionPlace == "F")
                {
                    competitionsPoint = competitionsPoint + 1200;
                    finals++;
                }
                else
                {
                    competitionsPoint = competitionsPoint + 720;
                    sf++;
                }
            }

            double averagePoints = ((wins * winPoints) + (finals * finalPoints) + (sf * semiFinals)) / competitions;

            Console.WriteLine($"Final points: {competitionsPoint}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{wins / (double)competitions * 100:f2}%");
        }
    }
}

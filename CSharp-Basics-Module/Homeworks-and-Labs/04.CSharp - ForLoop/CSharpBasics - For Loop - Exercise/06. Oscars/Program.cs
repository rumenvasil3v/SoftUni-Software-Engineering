using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int judgeN = int.Parse(Console.ReadLine());

            double pointsActor = 0;
            pointsActor = pointsActor + pointsAcademy;
            double pointsBcademy = 0;

            for (int i = 1; i <= judgeN; i++)
            {
                string judger = Console.ReadLine();
                int numberOfLetters = judger.Length;
                double points = double.Parse(Console.ReadLine());
                pointsActor = pointsActor + (numberOfLetters * points) / 2;

                if (pointsActor > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {pointsActor:f1}!");
                    break;
                }
            }

            if (pointsActor < 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - pointsActor:f1} more!");
            }
        }
    }
}

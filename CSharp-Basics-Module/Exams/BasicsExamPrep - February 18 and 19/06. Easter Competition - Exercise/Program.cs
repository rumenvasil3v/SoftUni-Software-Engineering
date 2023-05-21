using System;

namespace _06._Easter_Competition___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string topBakerName= string.Empty;
            int topBakerPoints = 0;
            for (int i = 1; i <= n; i++)
            {
                string currentBakerName = Console.ReadLine();
                int currentBakerPoints = 0;

                string command = Console.ReadLine();
                while(command != "Stop")
                {
                    int currentPoints = int.Parse(command);
                    currentBakerPoints += currentPoints;

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{currentBakerName} has {currentBakerPoints} points.");
                if (currentBakerPoints  > topBakerPoints)
                {
                    topBakerName = currentBakerName;
                    topBakerPoints = currentBakerPoints;
                    Console.WriteLine($"{currentBakerName} is the new number 1!");
                }
            }

            Console.WriteLine($"{topBakerName} won competition with {topBakerPoints} points!");
        }
    }
}

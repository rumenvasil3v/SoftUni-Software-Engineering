using System;

namespace _04._Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();

            int startPoints = 301;

            int points = 0;
            int successShots = 0;
            int failureShots = 0;
            string field = string.Empty;

            while ((field = Console.ReadLine()) != "Retire")
            {     
                points = int.Parse(Console.ReadLine());

                switch (field)
                {
                    case "Single":
                        if (points <= startPoints)
                        {
                            startPoints -= points;
                            successShots++;
                        }
                        else
                        {
                            failureShots++;
                        }
                        break;
                    case "Double":
                        points *= 2;
                        if (points <= startPoints)
                        {
                            startPoints -= points;
                            successShots++;
                        }
                        else
                        {
                            failureShots++;
                        }
                       
                        break;
                    case "Triple":
                        points *= 3;
                        if (points <= startPoints)
                        {
                            startPoints -= points;
                            successShots++;
                        }
                        else
                        {
                            failureShots++;
                        }
                        break;
                }

                if (startPoints <= 0)
                {
                    Console.WriteLine($"{nameOfPlayer} won the leg with {successShots} shots.");
                    break;
                }
            }

            if (field == "Retire")
            {
                Console.WriteLine($"{nameOfPlayer} retired after {failureShots} unsuccessful shots.");
            } 
        }
    }
}

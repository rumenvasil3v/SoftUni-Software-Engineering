using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int width = int.Parse(Console.ReadLine());
           int length = int.Parse(Console.ReadLine());
           int heigth = int.Parse(Console.ReadLine());

            int apartVolume = width * length * heigth;

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                apartVolume -= int.Parse(input);

                if (apartVolume < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(apartVolume)} Cubic meters more.");
                    break;
                }
            }

            if (input == "Done")
            {
                Console.WriteLine($"{apartVolume} Cubic meters left.");
            }
        }
    }
}

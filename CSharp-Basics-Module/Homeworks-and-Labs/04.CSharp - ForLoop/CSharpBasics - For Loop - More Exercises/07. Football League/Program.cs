using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            double fansA = 0;
            double fansB = 0;
            

            double fansV = 0;
            double fansG = 0;
            

            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    fansA++;
                }
                else if (sector == "B")
                {
                    fansB++;
                }
                else if (sector == "V")
                {
                    fansV++;
                }
                else
                {
                    fansG++;
                }
            }

            Console.WriteLine($"{fansA / fans * 100:f2}%");
            Console.WriteLine($"{fansB / fans * 100:f2}%");
            Console.WriteLine($"{fansV / fans * 100:f2}%");
            Console.WriteLine($"{fansG / fans * 100:f2}%");
            Console.WriteLine($"{(double)fans / (double)stadiumCapacity * 100:f2}%");
        }
    }
}

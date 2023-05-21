using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int f = floors; f >= 1; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f % 2 == 0 && f != floors)
                    {
                        Console.Write($"O{f}{r}{" "}");
                    }
                    if (f % 2 == 1 && f != floors)
                    {
                        Console.Write($"A{f}{r}{" "}");
                    }

                    if (f == floors)
                    {
                        Console.Write($"L{f}{r}{" "}");
                        
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

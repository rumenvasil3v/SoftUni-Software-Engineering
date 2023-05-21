using System;

namespace _01._Clock___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++)
            {
                int minutes = 0;
                while (minutes <= 59)
                {
                    Console.WriteLine($"{h}:{minutes}");
                    minutes++;
                }
            }
        }
    }
}

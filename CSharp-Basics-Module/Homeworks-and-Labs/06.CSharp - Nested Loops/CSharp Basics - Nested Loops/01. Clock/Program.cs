
using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;

            for (int h = 0; h <= 23; h++)
            {
                while (m <= 59)
                {
                        Console.WriteLine($"{h}:{m}");
                    m++;
                }
                m = 0;
            }
        }
    }
}

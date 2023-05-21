using System;

namespace _12._The_song_of_the_wheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pass = string.Empty;
            int passwordCount = 0;
            bool isPass = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d)
                            {
                                if (a * b + c * d == n)
                                {
                                    passwordCount++;
                                    Console.Write($"{a}{b}{c}{d} ");
                                    if (passwordCount == 4)
                                    {
                                        pass = $"{a}{b}{c}{d}";
                                        isPass = true ;
                                    }
                                }
                                    
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (isPass)
            { 
                Console.WriteLine($"Password: {pass}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}

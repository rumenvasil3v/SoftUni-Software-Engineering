using System;

namespace _04._Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());

            for (int a = startInterval; a <= endInterval; a++)
            {
                for (int b = startInterval; b <= endInterval; b++)
                {
                    for (int c = startInterval; c <= endInterval; c++)
                    {
                        for (int d = startInterval; d <= endInterval; d++)
                        {
                            if (a > d && (b + c) % 2 == 0)
                            {
                                if (a % 2 == 0)
                                {
                                    if (d % 2 != 0)
                                    {
                                        Console.Write($"{a}{b}{c}{d} ");
                                    }                                 
                                }
                                else if (a% 2 != 0)
                                {
                                    if (d % 2 == 0)
                                    {
                                        Console.Write($"{a}{b}{c}{d} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

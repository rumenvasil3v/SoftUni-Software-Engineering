using System;

namespace _08._Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int units = int.Parse(Console.ReadLine());

            int prime = 2;
            for (int a = 1; a <= hundreds; a++)
            {
                for (int b = 1; b <= tens; b++)
                {
                    for (int c = 1; c <= units; c++)
                    {
                        if (a % 2 == 0 && c % 2 == 0)
                        {
                            if (b == 1 || b == 4 || b == 6)
                            {
                                break;
                            }
                            else if (b > 1 && b <= 7)
                            {
                                Console.WriteLine($"{a} {b} {c}");
                            }
                        }
                    }
                }
            }
        }
    }
}

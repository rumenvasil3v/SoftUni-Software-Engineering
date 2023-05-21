using System;

namespace _03._Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            

            for (int num1 = 1; num1 <= 9; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    for (int num3 = 1; num3 <= 9; num3++)
                    {
                        for (int num4 = 1; num4 <= 9; num4++)
                        {
                            
                            if (num1 + num2 == num3 + num4 && n % (num1 + num2) == 0)
                            {
                                Console.Write($"{num1}{num2}{num3}{num4} ");
                            }
                            
                        }
                    }
                }
            }
        }
    }
}

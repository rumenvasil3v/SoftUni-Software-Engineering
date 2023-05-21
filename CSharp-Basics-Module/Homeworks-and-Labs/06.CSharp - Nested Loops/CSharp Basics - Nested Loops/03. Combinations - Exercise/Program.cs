using System;

namespace _03._Combinations___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isVaild = false;

            for (int x1 = 0; x1 <= n; x1++)
            {
                for (int x2 = 0; x2 <= n; x2++)
                {
                    int x3 = 0;
                    while (x3 <= n) 
                    {
                        if (x1 + x2 + x3 == n)
                        {
                            isVaild= true;
                        }
                        else
                        {
                            isVaild= false;
                        }

                        if (isVaild )
                        {
                            combinations++;
                        }

                        x3++;
                    }
                }
            }
            Console.WriteLine(combinations);
            
        }
    }
}

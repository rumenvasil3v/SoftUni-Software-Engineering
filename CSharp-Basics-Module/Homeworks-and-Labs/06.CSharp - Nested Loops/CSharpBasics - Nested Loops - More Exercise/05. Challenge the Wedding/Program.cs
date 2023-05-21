using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());
            bool isValid = false;

            int coupons = 0;

            while (maxTables > 0)
            {
                for (int i = 1; i <= men; i++)
                {
                    for (int j = 1; j <= women; j++)
                    {
                        coupons++;
                        maxTables--;
                        Console.Write($"({i} <-> {j}) ");
                        if (maxTables <= 0)
                        {
                            isValid= true;
                            break;
                        }
                        
                    }
                    if (isValid)
                    {
                        break;
                    }
                }
                if (isValid)
                {
                    break;
                }
                break;
            }
        }
    }
}

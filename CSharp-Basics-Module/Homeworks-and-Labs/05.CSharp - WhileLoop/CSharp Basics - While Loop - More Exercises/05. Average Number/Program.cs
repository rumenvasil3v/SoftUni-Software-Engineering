using System;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0:F2}",sum / n);
        }
    }
}

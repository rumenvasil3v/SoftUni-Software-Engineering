using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double uniformPriceExtras = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double sumUniformExtras = extras * uniformPriceExtras;
            double sumDecor = decor + sumUniformExtras;

          if (extras >= 150)
            {
                sumUniformExtras = sumUniformExtras - sumUniformExtras* 0.1;
                sumDecor = decor + sumUniformExtras;
            }

         if (sumDecor > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {sumDecor - budget:f2} leva more.");
            }
         else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - sumDecor:f2} leva left.");
            }
        }
    }
}

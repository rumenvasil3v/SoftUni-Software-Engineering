using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneySworn = double.Parse(Console.ReadLine());
            double yearPast = int.Parse(Console.ReadLine());


            double age = 18;


            for (int year  = 1800; year <= yearPast; year++)
            {
                if (year % 2 == 0)
                {
                    moneySworn = moneySworn - 12000;
                }
                else if (year % 2 != 0) 
                {
                    moneySworn = moneySworn - (12000 + (50 * age));
                }
                age++;
            }


            if (moneySworn >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneySworn:f2} dollars left.");
            }

            else 
            {
                Console.WriteLine($"He will need {Math.Abs(moneySworn):f2} dollars to survive.");
            }
        }
    }
}

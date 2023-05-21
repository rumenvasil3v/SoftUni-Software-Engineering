using System;
using System.IO;
/*
100
2
1.0
2.0
3.0

100
42
12.0
4.0
3.0
*/
namespace _09._PadawEquip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double pricePerLightsaber = double.Parse(Console.ReadLine());
            double pricePerRobe = double.Parse(Console.ReadLine());
            double pricePerBelt = double.Parse(Console.ReadLine());

            double addedPriceLightsabers = Math.Ceiling(countOfStudents + countOfStudents * 0.1);
            double totalExpenses = pricePerLightsaber * addedPriceLightsabers + pricePerRobe * countOfStudents + pricePerBelt * countOfStudents;

            for (int i = 1; i <= countOfStudents; i++)
            { 
                if (i % 6 == 0)
                {
                    totalExpenses -= pricePerBelt;
                }
            }

            if (amountOfMoney >= totalExpenses)
            {
                Console.WriteLine($"The money is enough - it would cost {(totalExpenses):f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalExpenses - amountOfMoney:f2}lv more.");
            }
        }
    }
}

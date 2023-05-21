using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console:
            int age = int.Parse(Console.ReadLine());// age of Lily
            double washingMachine = double.Parse(Console.ReadLine());// prce for washing machine
            int priceToy = int.Parse(Console.ReadLine());// price for toy 

            int money = 0;

            //2. Create loop for every birthday of Lily
           
            for (int i = 1; i <= age; i++)
            {
                // Condition whether birthday is even and add to her savings
                if (i % 2 == 0)
                {
                    money += i * 5 - 1; //  => if its even: she earns money = age * 5 -1
                }
                else
                {
                    money += priceToy;//  => if its not : she earns a toy
                }
            }
            //3. Condition whether her savings are enough for washing machine
            if (money >= washingMachine)
            {
                Console.WriteLine($"Yes! {money - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - money:f2}");
            }
        }
    }
}

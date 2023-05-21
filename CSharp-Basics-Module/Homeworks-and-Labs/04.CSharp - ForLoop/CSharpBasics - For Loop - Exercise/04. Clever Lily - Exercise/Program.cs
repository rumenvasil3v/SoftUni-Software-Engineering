using System;

namespace _04._Clever_Lily___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int toys = 0;
            double birthdayMoney = 0;
            double savedMoney = 0;
            int brother = 0;
           
            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    savedMoney += birthdayMoney;
                    birthdayMoney = birthdayMoney + 10;
                    brother++;
                }
                else if (birthday % 2 != 0)
                {
                    toys++;
                }
            }
            savedMoney += birthdayMoney;
            toys = toys * priceToy;
            savedMoney = (savedMoney + toys) - brother;

            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(washingMachinePrice - savedMoney):f2}");
            }
        }
    }
}

using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeed = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            string input; // spend or save
            double money;
            int countDays = 0; 
            int countSpend = 0;

            while (availableMoney < moneyNeed)
            {
                
                input= Console.ReadLine();
                money = double.Parse(Console.ReadLine());

                countDays++;

                if (input == "save")
                {
                    availableMoney += money;
                    countSpend = 0;
                }
                else
                {
                    countSpend++;
                    if(countSpend == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(countDays);
                        break;
                    }

                    availableMoney-= money;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            } 

            if (availableMoney >= moneyNeed)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
        }
    }
}

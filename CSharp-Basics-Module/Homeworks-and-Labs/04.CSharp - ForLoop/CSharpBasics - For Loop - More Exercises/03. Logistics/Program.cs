using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargos = int.Parse(Console.ReadLine());

            double tonnageBus = 0;
            double tonnageTruck = 0;
            double tonnageTrain = 0;
            double priceBus = 0;
            double priceTruck = 0;
            double priceTrain = 0;
            int allCargos = 0;

            for (int i = 1; i <= cargos; i++)
            { 
                int tonnageOfCargo = int .Parse(Console.ReadLine());
                allCargos += tonnageOfCargo;

                if (tonnageOfCargo <= 3)
                {
                    tonnageBus += tonnageOfCargo;
                    priceBus = tonnageBus * 200;
                }
                else if (tonnageOfCargo > 3 && tonnageOfCargo <= 11)
                {
                    tonnageTruck += tonnageOfCargo;
                    priceTruck = tonnageTruck * 175;
                }
                else
                {
                    tonnageTrain += tonnageOfCargo;
                    priceTrain = tonnageTrain * 120;
                }


            }

            double average = (priceBus + priceTruck + priceTrain) / allCargos;

            double percentBus = tonnageBus / allCargos * 100;
            double percentTruck = tonnageTruck / allCargos * 100;
            double percentTrain = tonnageTrain / allCargos * 100;

            Console.WriteLine("{0:F2}",average);
            Console.WriteLine($"{percentBus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}

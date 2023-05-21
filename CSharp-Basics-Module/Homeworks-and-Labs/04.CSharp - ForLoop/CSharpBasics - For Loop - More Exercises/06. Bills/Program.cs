using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double sumAnotherBills = 0;
            double anotherBills = 0;
            double electricityBill = 0;

            for (int i = 1; i <= months; i++)
            {
                double monthElectricyBill = double.Parse(Console.ReadLine());
                electricityBill+= monthElectricyBill;

                int waterBill = 20;
                int internet = 15;

                anotherBills = monthElectricyBill + waterBill + internet;
                anotherBills += anotherBills * 0.2;
                sumAnotherBills += anotherBills;
            }

            double averageBills = (electricityBill + months * 20 + months * 15 + sumAnotherBills) / months;

            Console.WriteLine($"Electricity: {electricityBill:f2} lv");
            Console.WriteLine($"Water: {months * 20:f2} lv");
            Console.WriteLine($"Internet: {months  *15:f2} lv");
            Console.WriteLine($"Other: {sumAnotherBills:f2} lv");
            Console.WriteLine($"Average: {averageBills:f2} lv");
        }
    }
}

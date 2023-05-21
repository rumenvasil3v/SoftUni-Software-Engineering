using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int dateDeposit = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            double sum = depositSum + dateDeposit * ((depositSum * interestRate*0.01) / 12);
            Console.WriteLine(sum);
        }
    }
}

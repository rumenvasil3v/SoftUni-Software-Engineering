using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberBase = double.Parse(Console.ReadLine());
            double numberPower = double.Parse(Console.ReadLine());
            double raisedNumber = RaisedToGivenPowerNumber(numberBase, numberPower);
            Console.WriteLine(raisedNumber);
        }

        static double RaisedToGivenPowerNumber(double numberBase, double numberPower)
        {
            return Math.Pow(numberBase, numberPower);
        }
    }
}

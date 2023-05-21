using System;

namespace USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. We read USD from the console.

            //2.We conversion from USD to BGN (1 USD = 1.79549.)

            //3.We print BGN from the console

            Console.Write("USD = ");
            double usd = double.Parse(Console.ReadLine());
            Console.Write("BGN = ");
            double lv = usd * 1.79549;
            Console.WriteLine(lv);
        }
    }
}

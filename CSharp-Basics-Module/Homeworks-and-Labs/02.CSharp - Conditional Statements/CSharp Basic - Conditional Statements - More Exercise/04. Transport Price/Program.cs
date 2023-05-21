using System;
using System.Diagnostics;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Variable for kilometers.
            int km = int.Parse(Console.ReadLine());
            //2. Variable for time.
            string time  = Console.ReadLine();
            //3. First tax is 0.70, day tax is 0.79 , night tax is 0.98, train tax is 0.06 and bus tax is 0.09.
            double firstTax = 0.70;
            double dayTax = 0.79;
            double nightTax = 0.90;
            double train = 0.06;
            double bus = 0.09;
            //4. Conditional statement if the kilometers are >= 100 ->
            // print train tax.
            if (km >= 100)
            {
                train = km * train;
                Console.WriteLine("{0:F2}", train);
            }
            //5. Conditional statement if the kilometers are >= 20 ->
            // print bus tax.
            else if (km >= 20)
            {
                bus = km * bus;
                Console.WriteLine("{0:F2}", bus);
            }
            //6. Conditional statement if the kilometers are < 20 and time is day.
            // print day tax + first tax.
            else if (time == "day")
            {
                dayTax = km * dayTax + firstTax;
                Console.WriteLine("{0:F2}", dayTax);
            }
            //4. Conditional statement if the kilometers are < 20 and time is night.
            // print night tax + first tax.
            else
            {
                nightTax = km * nightTax + firstTax;
                Console.WriteLine("{0:F2}",nightTax);
            }
        }
    }
}

using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double fruitPrice = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    fruitPrice = quantity * 2.50;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "apple")
                {
                    fruitPrice = quantity * 1.20;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "orange")
                {
                    fruitPrice = quantity * 0.85;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "grapefruit")
                {
                    fruitPrice = quantity * 1.45;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "kiwi")
                {
                    fruitPrice = quantity * 2.70;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "pineapple")
                {
                    fruitPrice = quantity * 5.50;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "grapes")
                {
                    fruitPrice = quantity * 3.85;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }           
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    fruitPrice = quantity * 2.70;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "apple")
                {
                    fruitPrice = quantity * 1.25;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "orange")
                {
                    fruitPrice = quantity * 0.90;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "grapefruit")
                {
                    fruitPrice = quantity * 1.60;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "kiwi")
                {
                    fruitPrice = quantity * 3.00;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "pineapple")
                {
                    fruitPrice = quantity * 5.60;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else if (fruit == "grapes")
                {
                    fruitPrice = quantity * 4.20;
                    Console.WriteLine("{0:F2}", fruitPrice);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
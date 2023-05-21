using System;

namespace _02._Triangle_Areaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;
            Console.WriteLine(Convert.ToDecimal(string.Format("{0:F2}", area)));
        }
    }
}

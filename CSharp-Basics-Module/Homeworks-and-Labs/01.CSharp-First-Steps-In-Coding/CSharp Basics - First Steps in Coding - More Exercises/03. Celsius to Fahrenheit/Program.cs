using System;

namespace _03._Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            
            double fahrenheit = fahrenheit = (celsius * 9/5) + 32;
            
            Console.WriteLine(Convert.ToDecimal(string.Format("{0:F2}", fahrenheit)));
        }
    }
}

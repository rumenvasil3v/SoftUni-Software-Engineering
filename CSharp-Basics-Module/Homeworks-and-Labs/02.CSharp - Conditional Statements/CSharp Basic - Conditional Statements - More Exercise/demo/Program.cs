using System;
using System.Globalization;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int InputNumber = 00589;
            Console.WriteLine(InputNumber.ToString("D3", CultureInfo.InvariantCulture));
            Console.ReadLine();
            
        }
    }
}

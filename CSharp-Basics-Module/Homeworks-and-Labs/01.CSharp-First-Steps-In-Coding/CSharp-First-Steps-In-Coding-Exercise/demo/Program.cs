using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The numbers, which we read are: {num + num2} ");
        }
    }
}

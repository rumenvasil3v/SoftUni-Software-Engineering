using System;

namespace CSharpFundamentals___Methods___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                int number = int.Parse(Console.ReadLine());
                DataType(number);
            }
            else if (dataType == "real")
            {
                double number = double.Parse(Console.ReadLine());
                DataType(number);
            }
            else if (dataType == "string")
            {
                string randomString = Console.ReadLine();
                DataType(randomString);
            }
        }

        static void DataType(int number)
        {
            int result = number * 2;
            Console.WriteLine(result);
        }

        static void DataType(double number)
        {
            double result = number * 1.5;
            Console.WriteLine("{0:F2}", result);
        }

        static void DataType(string randomString)
        {
            Console.WriteLine($"${randomString}$");
        }
    }
}

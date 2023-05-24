using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort meters = ushort.Parse(Console.ReadLine());
            float kiloMeters = meters / 1000f;
            Console.WriteLine("{0:F2}", kiloMeters);
        }
    }
}

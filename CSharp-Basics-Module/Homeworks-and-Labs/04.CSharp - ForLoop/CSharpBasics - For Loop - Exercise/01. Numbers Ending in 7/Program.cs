using System;

namespace _01._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //i=i+10 => i+=10
            for (int i = 7; i <= 1000; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;

namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int n1 = 2; n1 <= num1; n1++)
            {
                for (int n2 = 2; n2 <= num2; n2++)
                {
                    if (n2 == 2 || n2 == 3 || n2 == 5 || n2 == 7)
                    {
                        for (int n3 = 2; n3 <= num3; n3++)
                        {
                            if (n1 % 2 == 0 && n3 % 2 == 0)
                            {               
                                    Console.WriteLine($"{n1} {n2} {n3}");  
                            }
                        }
                    }
                }
            }
        }
    }
}

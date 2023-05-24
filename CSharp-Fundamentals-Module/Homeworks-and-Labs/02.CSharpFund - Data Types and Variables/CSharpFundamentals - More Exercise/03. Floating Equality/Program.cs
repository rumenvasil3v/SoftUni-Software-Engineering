using System;
/*
 eps = 0.000_001
 5.000_000_03

5.00000001
5.00000003

-4.999999
-4.999998

4.999999
4.999998

5.00000005
5.00000001

5.3
6.01 
 */
namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double substracting = Math.Abs(a - b);
            
            double eps = 0.000001;
            
            if (eps > substracting)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
